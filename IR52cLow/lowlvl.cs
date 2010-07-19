using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Threading;

//*****************************************************************************************
//                           LICENSE INFORMATION
//*****************************************************************************************
//   IR52cLow Version 1.0
//   Class file for managing the Eurobtec IR52c 5-DOF robotic arm
//   
//   Copyright (C) 2010 
//   Chris MAVRAKIS, Themistoklis KYRGOS, Savvas A. CHATZICHRISTOFIS
//   Emails: cmavr8@gmail.com, thmsxthms@gmail.com, schatzic@ee.duth.gr
//   
//   This file is part of IR52cLow.
//
//   IR52cLow is free software: you can redistribute it and/or modify
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
//   along with IR52cLow.  If not, see <http://www.gnu.org/licenses/>.
namespace IR52cLow
{
    //lowlvl stands for Low Level and contains a set of low level commands that are passed to the Robot via the CommunicationManager class.
    public class lowlvl
    {
        #region Settings
        public double[] motorMaxAngles = new double[5] { 273.44, 172.8, 200, 200, 348.75 }; //MaxDegrees for each motor
        int[] currentsteps = new int[5];
        #endregion

        #region Converters - Converting angles to robot's motors' steps
        double[] motorsteps = new double[5] { 403000 / 290, 240000 / 180, 284000 / 200, 267000 / 200, 32000 / 360 }; //MaxSteps/MaxDegrees for each motor
        public int[] angle2steps(double[] angle, RoboMath.AngleUnitTypes type) //Convert an angle array (double) to motor steps (int)
        {
            int[] steps = new int[5];
            if (type == RoboMath.AngleUnitTypes.Degrees) //If angle input is in degrees
            {
                for (int i = 0; i <= 4; i++)
                    if (angle[i] != 0)
                        steps[i] = Convert.ToInt32(motorsteps[i] * angle[i]);
            }
            else //If angle input is in rad
            {
                for (int i = 0; i <= 4; i++)
                    if (angle[i] != 0)
                        steps[i] = Convert.ToInt32(motorsteps[i] * angle[i] / 180 * Math.PI);
            }
            return steps;
        } 

        public double[] steps2angle(int[] steps, RoboMath.AngleUnitTypes type)
        {
            double[] angles = new double[5];
            if (type == RoboMath.AngleUnitTypes.Degrees) //If angle input output needs to be in degrees
            {
                for (int i = 0; i <= 4; i++)
                     angles[i] = (double)(steps[i]/motorsteps[i]);
            }
            else //If angle output needs to be in rad
            {
                for (int i = 0; i <= 4; i++)
                    angles[i] = (double)((steps[i] * Math.PI) / (motorsteps[i] * 180));
            }
            return angles;

        }
        #endregion

        #region Constructing
        public CommunicationManager comm; //New instance of CommunicationManager type object.
        public lowlvl()
        {
            comm = new CommunicationManager();
        }
        #endregion

        #region Open Port
        public void  portopen(RichTextBox rtbDisplay) //Open serial port
        {
            //Throw new System.NotImplementedException();
            comm.Parity = "None";
            comm.StopBits = "One";
            comm.DataBits = "8";
            comm.BaudRate = "19200";
            comm.DisplayWindow = rtbDisplay;
            comm.OpenPort();
        }
         #endregion

        #region Init
        // Initialization sequence for the IR52c robot

        public void init(string option)
        {
            // Motor initial settings array:
            int[,] initdata = new int[5, 12] { 
            {0,50,70,5000,1000,1000,10,100,50,190000,-190000,190000},
            {0,80,60,5000,1500,1000,10,100,50,120000,-120000,120000},
            {0,60,60,5000,1000,1000,10,150,50,142000,-142000,142000},
            {0,40,70,5000,1500,1000,10,100,50,133500,-133500,133500}, 
            {0,90,90,5000,1000,1000,10,100,50,15500,-15500,15500}};
            
            int delay = 50;

            if (option != "gotohome") // Do the full init process.
            {
                comm.WriteData("SYS\r\n", delay); //Quering controller for System status
                comm.WriteData("SYS\r\n", delay);
                comm.WriteData("ZY8000\r\n", delay);

                // Motor initialization
                for (int motor = 0; motor <= 4; motor++)
                {
                    comm.WriteData("KV" + motor + " " + initdata[motor, 0] + "\r\n", delay);
                    comm.WriteData("KP" + motor + " " + initdata[motor, 1] + "\r\n", delay);
                    comm.WriteData("KD" + motor + " " + initdata[motor, 2] + "\r\n", delay);
                    comm.WriteData("KI" + motor + " " + initdata[motor, 3] + "\r\n", delay);
                    comm.WriteData("IL" + motor + " " + initdata[motor, 4] + "\r\n", delay);
                    comm.WriteData("SF" + motor + " " + initdata[motor, 5] + "\r\n", delay);
                    comm.WriteData("RM" + motor + " " + initdata[motor, 6] + "\r\n", delay);
                    comm.WriteData("VP" + motor + " " + initdata[motor, 7] + "\r\n", delay);
                    comm.WriteData("WIN" + motor + " " + initdata[motor, 8] + "\r\n", delay);
                    comm.WriteData("PEP" + motor + " " + initdata[motor, 9] + "\r\n", delay);
                    comm.WriteData("PEN" + motor + "" + initdata[motor, 10] + "\r\n", delay); //This always has a negative value
                }
                delay = 1000;
                //Final init commands (AEx and SNUx)
                for (int motor = 0; motor <= 4; motor++)
                {
                    comm.WriteData("AE" + motor + "\r\n", delay);
                }
                delay = 2000;
            }else{ //"Lite" init will be done
                delay = 1000;
            }
            for (int motor = 0; motor <= 4; motor++)
            {
                    comm.WriteData("SNU" + motor + " " + initdata[motor, 11] + "\r\n",delay*3);
            }
            comm.WriteData("PR1 1500\r\n", delay);
            comm.WriteData("AD1\r\n", delay/40);
            comm.WriteData("NU1\r\n", delay / 40);
            comm.WriteData("AE1\r\n", delay / 40);
            comm.WriteData("PR4-4400\r\n", delay); //Correct discrepancy between model and real arm's end effector (gripper)
            comm.WriteData("AD4\r\n", delay / 40);
            comm.WriteData("NU4\r\n", delay / 40);
            comm.WriteData("AE4\r\n", delay / 40);
        }
#endregion

        #region Absolute Movement
        int d = 60; //60 is the delay needed between commands given to the robot's controller
        //Moves a given motor to a given angle (measured in steps from its zero-point)
        public void m_abs(int step,int motor)
        {
            comm.WriteData("PA"+motor+" " + step + "\r\n", d); //Send command for absolute movement
        }
        #endregion

        #region Relative Movement
        //Functions to move each motor relatively to its current position
        //Motor 0 buttons
        public void m0minus(int step)
        {
            comm.WriteData("PR0-" + step + "\r\n",d); //Gets amount of step from m0step comboBOX
        }

        public void m0plus(int step)
        {
            comm.WriteData("PR0 " + step + "\r\n", d);
        }

        //Motor 1 buttons
        public void m1minus(int step)
        {
            comm.WriteData("PR1-" + step + "\r\n", d);
        }

        public void m1plus(int step)
        {
            comm.WriteData("PR1 " + step + "\r\n", d);
        }

        //Motor 2 buttons
        public void m2minus(int step)
        {
            comm.WriteData("PR2-" + step + "\r\n", d);
        }

        public void m2plus(int step)
        {
            comm.WriteData("PR2 " + step + "\r\n", d);
        }

        //Motor 3 buttons
        public void m3minus(int step)
        {
            comm.WriteData("PR3-" + step + "\r\n", d);
        }

        public void m3plus(int step)
        {
            comm.WriteData("PR3 " + step + "\r\n", d);
        }


        //Motor 4 buttons
        public void m4minus(int step)
        {
            comm.WriteData("PR4-" + step + "\r\n", d);
        }

        public void m4plus(int step)
        {
            comm.WriteData("PR4 " + step + "\r\n", d);
        }

        //Gripper buttons
        public void mgripminus(int step)
        {
            comm.WriteData("GR-" + step + "\r\n", d);
        }

        public void mgripplus(int step)
        {
            comm.WriteData("GR+" + step + "\r\n", d);
        }


        #endregion

        #region Get each joint's angle
        //Reads each joint's current position (in steps), parse it to integer and convert to angle.
        public double[] GetJointsAngles()
        {
            double[] angles = steps2angle(comm.positions, RoboMath.AngleUnitTypes.Degrees);
            angles[1] += 90;
            return angles;
        }
        public void GetJointsAngles_contd()
        {
            int delay = 100;
            comm.WriteData("angles", delay); //Ask the CommunicationManager object comm to get robot's angles      
        }
        #endregion

        #region Stop
        //Emergency STOP function: Stops all motors except gripper (can be used with a button on an interface)
        public void stop()
        {
            int delay = 50;
            comm.WriteData("STOP0\r\n",delay);
            comm.WriteData("STOP1\r\n", delay);
            comm.WriteData("STOP2\r\n", delay);
            comm.WriteData("STOP3\r\n", delay);
            comm.WriteData("STOP4\r\n", delay);
        }
        #endregion

        #region TalkToBot
        //Send any text to robot's controller
        public void TalkToBot(string text)
        {
            int delay = 50;
            comm.WriteData(text + "\r\n",delay);
        }

        #endregion

    }
}
