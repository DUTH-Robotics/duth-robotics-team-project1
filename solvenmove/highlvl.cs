﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RoboMath;
using System.Windows.Forms;
using IR52cLow;

//*****************************************************************************************
//                           LICENSE INFORMATION
//*****************************************************************************************
//   5-DOF SolveNMove highlvl Version 1.0
//   Class file for sovling the direct and inverse kinematic problem and moving a 5-Degrees-Of-Freedom robotic arm
//   
//   Copyright (C) 2010 
//   Chris MAVRAKIS, Themistoklis KYRGOS, Savvas A. CHATZICHRISTOFIS
//   Emails: cmavr8@gmail.com, thmsxthms@gmail.com, schatzic@ee.duth.gr
//   
//   This file is part of the 5-DOF SolveNMove project.
//
//   5-DOF SolveNMove is free software: you can redistribute it and/or modify
//   it under the terms of the GNU General Public License as published by
//   the Free Software Foundation, either version 3 of the License, or
//   (at your option) any later version.
//
//   IR52cLow is distributed in the hope that it will be useful,
//   but WITHOUT ANY WARRANTY; without even the implied warranty of
//   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//   GNU General Public License for more details.
//
//   You should have received a copy of the GNU General Public License
//   along with 5-DOF SolveNMove.  If not, see <http://www.gnu.org/licenses/>.

namespace solvenmove
{
    //highlvl stands for High Level and contains functions 
    //that can have cartesian coordinates as input. Movement 
    //equations are used to calculate the angles at which each 
    //motor should be turned and passed to lowlvl functions.
    public class highlvl
    {
        #region Constructor
        public lowlvl lowlvlobj;
        private class Move
        {
            public bool RelativeMove = false;
            public bool AbsoluteMove = false;
            public double[] parameters;
            public bool Gripper = false;
            public bool Open; //true to open, false to close
        }
        roboMath mathobject;
        volatile RichTextBox Dsp;
        Queue<Move> QueuedMoves = new Queue<Move>();
        public highlvl(RichTextBox DebugDsp) 
        {
            Dsp=DebugDsp;
            lowlvlobj = new lowlvl(); //Construct new low level object
            lowlvlobj.portopen(DebugDsp); //Open communications port with robot
         //   lowlvlobj.init(); //Initialize the robot (goto initial position)
            mathobject = new roboMath(0, 0, 0, 0, 0, AngleUnitTypes.Degrees); //object of class roboMath
        }
        #endregion
        private double X, Y, Z, R, P, Ya; //Global vars to keep X,Y,Z (in mm) and Roll, Pitch, Yaw (in degrees)

        public void movehigh_rel(double x, double y, double z,double Roll, double Pitch, double Yaw) //Moves the robot to a position given in contrast to current position
        {
            if (QueuedMoves.Count != 0)
            {
                Move m = new Move();
                m.RelativeMove = true;
                m.parameters = new double[6] { x, y, z, Roll, Pitch, Yaw };
                QueuedMoves.Enqueue(m);
                return;
            }
            //Copy input to global vars
            X = x;
            Y = y;
            Z = z;
            R = Roll;
            P = Pitch;
            Ya = Yaw;

            lowlvlobj.comm.m1 = movehigh_rel_contd; //Register movehigh_rel_contd function to communications manager's notifier "m1"
            lowlvlobj.GetJointsAngles_contd(); //Ask communications manager object to ask the robot for its current angles (via low level object)
        }

        public void movehigh_rel_next()
        {
            Move m;
            if (QueuedMoves.Count != 0)
            {
                m = QueuedMoves.Dequeue();
                //Copy input to global vars
                X = m.parameters[0];
                Y = m.parameters[1];
                Z = m.parameters[2];
                R = m.parameters[3];
                P = m.parameters[4];
                Ya = m.parameters[5];

                lowlvlobj.comm.m1 = movehigh_rel_contd; //Register movehigh_rel_contd function to communications manager's notifier "m1"
                lowlvlobj.GetJointsAngles_contd(); //Ask communications manager object to ask the robot for its current angles (via low level object)
                return;
            }
        }

        //Helper function for movehigh_rel. Control returns here after lowlvlobj.comm.m1() has the angles ready
        //x,y,z in mm and Roll, Pitch, Yaw in degrees
        public void movehigh_rel_contd() 
        {
            double x, y, z, Roll, Pitch, Yaw; //Local vars to keep X,Y,Z and Roll, Pitch, Yaw
            //Copy global vars to local vars:
            x = X;
            y = Y;
            z = Z;
            Roll = R;
            Pitch = P;
            Yaw = Ya;

            //Solve direct kinematic problem to get current robot's angles
            double[,] oldT = RoboMath.roboMath.calculateDH(lowlvlobj.GetJointsAngles(), AngleUnitTypes.Degrees);

            //Convert NSA to Roll-pitch-yaw (in radians)
            double[] rpy = new double[3];
            rpy = nsa2rpy(oldT);

            //Add new rpy to existing rpy, after converting them to radians
            rpy[0] += Roll * Math.PI / 180;
            rpy[1] += Pitch * Math.PI / 180;
            rpy[2] += Yaw * Math.PI / 180;
            
            //Now convert new Roll-pitch-yaw to NSA vectors
            double[,] nsa = new double[3,3];
            nsa = rpy2nsa(rpy);

            //Create new T matrix to hold the new position of the robot
            double[,] newT = new double[4, 4];
            //and copy nsa vectors to it
            for (int i = 0; i < 3; ++i)
                for (int j = 0; j < 3; ++j)
                    newT[i, j] = nsa[i, j];

            //Modify the new T matrix to show new position
            newT[0, 3] = oldT[0,3] + x;
            newT[1, 3] = oldT[1, 3] + y;
            newT[2, 3] = oldT[2, 3] + z;

            //Add newT's last line
            newT[3, 0] = newT[3, 1] = newT[3, 2] = 0;
            newT[3, 3] = 1;

            //Calculate degrees for the new matrix
            double[][] newthetas = SolveInverse(newT);
           
            //Move robot to the new (absolute) position
            move_abs(newthetas);
            if (QueuedMoves.Count != 0) movehigh_rel_next();
        }

        //x,y,z in mm, Roll,Pitch,Yaw in degrees
        public void movehigh_abs(double x, double y, double z, double Roll, double Pitch, double Yaw) //Moves the robot to an absolute position
        {
            double[,] newT = new double[4,4]; //The T matrix of the desired position

            //Modify new T matrix to show new position
            newT[0, 3] = x;
            newT[1, 3] = y;
            newT[2, 3] = z;

            //Modify new T matrix to show new orientation

            double[] rpy = new double[3]; //Holds roll-pitch-yaw angles in radians

            //convert Roll,Pitch,Yaw to rads (r,p,y)
            rpy[0] = Roll * 2 * Math.PI / 360;
            rpy[1] = Pitch * 2 * Math.PI / 360;
            rpy[2] = Yaw * 2 * Math.PI / 360;
            
            //Convert Roll-pitch-yaw to NSA
            double[,] nsa = new double[3, 3];
            nsa = rpy2nsa(rpy);

            //Save rot into newT
            for (int i=0; i < 3; ++i)
                for (int j=0; j < 3; ++j)
                    newT[i, j] = nsa[i, j];

            //Add newT's last line
            newT[3, 0] = newT[3, 1] = newT[3, 2] = 0;
            newT[3, 3] = 1;

            //Calculate degrees for the new matrix
            double[][] newthetas = SolveInverse(newT);

            //Move robot to the new (absolute) position
            move_abs(newthetas);
        }

        #region NSA-RPY converters
        //Converts nsa vectors to Roll-pitch-yaw angles (radians)
        public double[] nsa2rpy(double[,] nsa)
        {
            //n,s,a GeneralMatrix object
            MatrixManipulation.GeneralMatrix NSA = MatrixManipulation.GeneralMatrix.FromDoubleArray(new double[3, 3] 
                { { nsa[0,0], nsa[0,1], nsa[0,2] }, 
                { nsa[1,0], nsa[1,1], nsa[1,2] }, 
                { nsa[2,0], nsa[2,1], nsa[2,2] } });

            double rotAngleY = Math.PI / 2; //Holds angle by which the matrix will be rotated
            //Transformation matrix Ry. Will be used to transform nsa matrix to math the roll-pitch-yaw transformation coordinate system
            MatrixManipulation.GeneralMatrix Ry = MatrixManipulation.GeneralMatrix.FromDoubleArray(new double[3, 3] 
                { { Math.Cos(rotAngleY), 0, Math.Sin(rotAngleY) }, 
                { 0, 1, 0 }, 
                { -Math.Sin(rotAngleY), 0, Math.Cos(rotAngleY) } });

            double rotAngleX = -Math.PI; //Holds angle by which the matrix will be rotated
            //Transformation matrix Rx. 
            MatrixManipulation.GeneralMatrix Rx = MatrixManipulation.GeneralMatrix.FromDoubleArray(new double[3, 3] 
                { { 1, 0, 0 }, 
                { 0, Math.Cos(rotAngleX), -Math.Sin(rotAngleX) }, 
                { 0, Math.Sin(rotAngleX), Math.Cos(rotAngleX) } });

            //Now transform nsa matrix to math the roll-pitch-yaw transformation coordinate system
            double[,] nsaTemp = new double[3, 3]; //Temporary rotation matrix containing n,s,a vectors. 
            nsaTemp = MatrixManipulation.GeneralMatrix.ToDoubleArray(NSA * Ry * Rx);

            double[] rpy = new double[3]; //Roll-pitch-yaw angles will be saved here

            rpy[0] = Math.Atan2(nsaTemp[1, 0], nsaTemp[0, 0]);
            rpy[1] = Math.Atan2(-nsaTemp[2, 0], Math.Sqrt(nsaTemp[2, 1] * nsaTemp[2, 1] + nsaTemp[2, 2] * nsaTemp[2, 2]));
            rpy[2] = Math.Atan2(nsaTemp[2, 1], nsaTemp[2, 2]);
            //These are in Radians!

            return rpy;
        }

        //Converts Roll-pitch-yaw angles to n,s,a vectors. rpy[0] is roll, rpy[1] is pitch, rpy[2] is yaw in radians.
        public double[,] rpy2nsa(double[] rpy)
        {
            //New Roll-pitch-yaw To n,s,a conversion method
            double[,] nsaTemp = new double[3, 3]; //Temporary matrix containing n,s,a vectors. 

            //Functions to convert roll, pitch, yaw to n,s,a. Be careful: the n,s,a vectors produced are not correctly positioned in our coordinate system. Further transformations need to be done
            nsaTemp[0, 0] = Math.Cos(rpy[2]) * Math.Cos(rpy[1]);
            nsaTemp[0, 1] = Math.Cos(rpy[2]) * Math.Sin(rpy[1]) * Math.Sin(rpy[0]) - Math.Sin(rpy[2]) * Math.Cos(rpy[0]);
            nsaTemp[0, 2] = Math.Cos(rpy[2]) * Math.Sin(rpy[1]) * Math.Cos(rpy[0]) + Math.Sin(rpy[2]) * Math.Sin(rpy[0]);

            nsaTemp[1, 0] = Math.Sin(rpy[2]) * Math.Cos(rpy[1]);
            nsaTemp[1, 1] = Math.Sin(rpy[2]) * Math.Sin(rpy[1]) * Math.Sin(rpy[0]) + Math.Cos(rpy[2]) * Math.Cos(rpy[0]);
            nsaTemp[1, 2] = Math.Sin(rpy[2]) * Math.Sin(rpy[1]) * Math.Cos(rpy[0]) - Math.Cos(rpy[2]) * Math.Sin(rpy[0]);

            nsaTemp[2, 0] = -Math.Sin(rpy[1]);
            nsaTemp[2, 1] = Math.Cos(rpy[1]) * Math.Sin(rpy[0]);
            nsaTemp[2, 2] = Math.Cos(rpy[1]) * Math.Cos(rpy[0]);

            double rotAngleX = Math.PI; //Holds angle by which the matrix will be rotated
            //Transformation matrix Rx. Will be used to transform calculated rot matrix to math the robot's coordinate system
            MatrixManipulation.GeneralMatrix Rx = MatrixManipulation.GeneralMatrix.FromDoubleArray(new double[3, 3] 
                { { 1, 0, 0 }, 
                { 0, Math.Cos(rotAngleX), -Math.Sin(rotAngleX) }, 
                { 0, Math.Sin(rotAngleX), Math.Cos(rotAngleX) } });


            double rotAngleY = -Math.PI / 2; //Holds angle by which the matrix will be rotated
            //Transformation matrix Ry.
            MatrixManipulation.GeneralMatrix Ry = MatrixManipulation.GeneralMatrix.FromDoubleArray(new double[3, 3] 
                { { Math.Cos(rotAngleY), 0, Math.Sin(rotAngleY) }, 
                { 0, 1, 0 }, 
                { -Math.Sin(rotAngleY), 0, Math.Cos(rotAngleY) } });

            MatrixManipulation.GeneralMatrix nsa = new MatrixManipulation.GeneralMatrix(3, 3);
            nsa = MatrixManipulation.GeneralMatrix.FromDoubleArray(nsaTemp);

            //Now rotate calculated rot matrix to math the robot's coordinate system
            nsa = MatrixManipulation.GeneralMatrix.ToDoubleArray(nsaTemp * Rx * Ry);

            return nsa;
        }

#endregion

        public void move_abs(double[][] newthetas)
        {
            int i; //Declared outside for loop, to maintain it for later use
            
            for (i = 0; i <= 3; ++i)
            {
                int j;
                newthetas[i][1] -= 90; //Correct math model/robot model offset before sending to robot
             //   newthetas[i][4] += 90;
              //  newthetas[i][0] += 45; 

                for (j = 0; j < 5; ++j)
                    if (Math.Abs(newthetas[i][j]) > lowlvlobj.motorMaxAngles[j] / 2) break; //Break inner for loop if calculated angle exceeds motor's limit
                if (j == 5) break; //Break outer for loop if all angles of current solution are within limits
            }

            //Check if a valid solution was NOT found
            if (i == 4)
            {
                //Dsp.AppendText("Move is out of Robot's limits!\n");
                return;
            }

            //calculate steps (from angle)
            int[] steps = lowlvlobj.angle2steps(newthetas[i], AngleUnitTypes.Degrees);

            //Now move the robot! (using highlvl.movebot_low) 
            move_abs(steps);
        }

        private void move_abs(int[] steps)
        {
            int delay = 50;
            int i;
            //move each motor, according to the steps given by steps array
            for (i = 0; i < 5; i++)
            {
                System.Threading.Thread.Sleep(delay);
                lowlvlobj.m_abs(steps[i], i);
            }
        }

        #region Depreciated move functions (mostly relative)

        //Gets xyz and orientation matrix and moves robot
        public void move(double[][] newthetas)
        {
            //lowlvlobj.comm.MainThreadNotif m1;
            thetas = newthetas;
            lowlvlobj.comm.m1 = move_contd;
            lowlvlobj.GetJointsAngles_contd();
            
        }
        private double[][] thetas;
        public void move_contd()
        {
            double[] oldthetas = lowlvlobj.GetJointsAngles();
            double[][] newthetas = thetas;
            //Check  if angles calculated are within motor's limit for each solution
            int i; //Declared outside for loop, to maintain it for later use
            for (i = 0; i <= 3; ++i)
            {
                int j;
                for (j = 0; j < 5; ++j)
                    if (Math.Abs(newthetas[i][j]) > lowlvlobj.motorMaxAngles[j] / 2) break; //Break inner for loop if calculated angle exceeds motor's limit
                if (j==5) break; //break outer for loop if all angles of current solution are within limits
            }

            //Check if a valid solution was NOT found
            if (i == 4) return;

            double[] movethetas = new double[5]; //Relative angles to move each motor
            //Subtract old angles from new ones
            for (int j = 0; j <= 4; ++j)
            {
                movethetas[j] = newthetas[i][j] - oldthetas[j];
            }

            //calculate steps (from angle)

            int[] steps = lowlvlobj.angle2steps(movethetas, AngleUnitTypes.Degrees);

            //Now move the robot! (using highlvl.movebot_low) 
            move(steps);

        }

        private void move(int[] steps)
        {
            int delay = 50;

            //move each motor, according to the steps given by steps array
            System.Threading.Thread.Sleep(delay);
            if (steps[0] >= 0) lowlvlobj.m0plus(steps[0]);
            else lowlvlobj.m0minus(Math.Abs(steps[0]));

            System.Threading.Thread.Sleep(delay);
            if (steps[1] >= 0) lowlvlobj.m1plus(steps[1]);
            else lowlvlobj.m1minus(Math.Abs(steps[1]));

            System.Threading.Thread.Sleep(delay);
            if (steps[2] >= 0) lowlvlobj.m2plus(steps[2]);
            else lowlvlobj.m2minus(Math.Abs(steps[2]));

            System.Threading.Thread.Sleep(delay);
            if (steps[3] >= 0) lowlvlobj.m3plus(steps[3]);
            else lowlvlobj.m3minus(Math.Abs(steps[3]));

            System.Threading.Thread.Sleep(delay);
            if (steps[4] >= 0) lowlvlobj.m4plus(steps[4]);
            else lowlvlobj.m4minus(Math.Abs(steps[4]));
        }
        #endregion

        public double[][] SolveInverse(double[,] T) //Solve the inverse kinematic problem. Supplies the T position-orientation matrix to the appropriate math function, and converts the results to degrees.
        {
            return roboMath.convertRadtoDegrees(roboMath.CalculateReverse(T)); 
        }
        public void init(string option) //Initialize the robotic arm
        {
            lowlvlobj.init(option);
        }
        public void GripperClose() //Close the robotic arm's gripper or other tool
        {
            lowlvlobj.mgripminus(4);
        }
        public void GripperOpen() //Close the robotic arm's gripper or other tool
        {
            lowlvlobj.mgripplus(4);
        }
    } 
}
