﻿using System;
using MatrixManipulation;

//*****************************************************************************************
//                           LICENSE INFORMATION
//*****************************************************************************************
//   5-DOF SolveNMove RoboMath Version 1.0
//   Class file for sovling the direct and inverse kinematic problem
//   
//   Copyright (C) 2010 
//   Chris MAVRAKIS, Themistoklis KYRGOS, Savvas A. CHATZICHRISTOFIS
//   Emails: cmavr8@gmail.com, thmsxthms@gmail.com, schatzic@ee.duth.gr
//
//   Special thanks to Epaminondas Latanis and Angelos Koufakis for their precious help
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

/* TODO
 * rename Reverse to inverse
 * 
 */

namespace RoboMath
{
    public enum AngleUnitTypes { Radians, Degrees }; 

    /// <summary>
    /// RoboMath stands for High Level and contains functions 
    /// that can have cartesian coordinates as input. Movement 
    /// equations are used to calculate the angles at which each 
    /// motor should be turned and passed to lowlvl functions.
    /// </summary>
    public class roboMath
    {
        #region Settings
        private static int[] link = { 285, 200, 200, 100, 72 }; // Set the lengths of the several parts of the robotic arm.
        public int[] ArmLengths
        {
            get { return link; }
        }

        private AngleUnitTypes m_AngleUnits;
        public AngleUnitTypes AngleUnits
        {
            get { return m_AngleUnits; }
            set { m_AngleUnits = value; }
        }

        private double[] m_thetaAngles;
        public double[] thetaAngles
        {
            get { return m_thetaAngles; }
            set { m_thetaAngles = value; }
        }

        private double[,] m_T;
        public double[,] DH_Table
        {
            get { return m_T; }
            set { m_T = value; }
        }
        #endregion

        #region Constructors
        public roboMath()
        {
            m_AngleUnits = AngleUnitTypes.Radians;
            m_thetaAngles = new double[5];
            m_T = new double[4, 4];
        }

        public roboMath(double th1, double th2, double th3, double th4, double th5)
        {
            m_AngleUnits = AngleUnitTypes.Radians;
            m_thetaAngles = new double[5] { th1, th2, th3, th4, th5 };
            m_T = new double[4, 4];
        }

        public roboMath(double th1, double th2, double th3, double th4, double th5, AngleUnitTypes AnglesUnits)
        {
            m_AngleUnits = AnglesUnits;
            m_thetaAngles = new double[5] { th1, th2, th3, th4, th5 };
            m_T = new double[4, 4];
        }

        public roboMath(double[] th)
        {
            if (th.Length != 5)
                throw new ArgumentException("Constructing roboMath class failed! Theta angles given must be an array of 5 doubles", "th");
            m_AngleUnits = AngleUnitTypes.Radians;
            m_thetaAngles = th;
            m_T = new double[4, 4];
        }

        public roboMath(double[] th, AngleUnitTypes AnglesUnits)
        {
            if (th.Length != 5)
                throw new ArgumentException("Constructing roboMath class failed! Theta angles given must be an array of 5 doubles", "th");
            m_AngleUnits = AnglesUnits;
            m_thetaAngles = th;
            m_T = new double[4, 4];
        }

        public roboMath(double[,] T)
        {
            if (T.Rank != 2 || (T.GetLength(0) != 4) || (T.GetLength(1) != 4))
                throw new ArgumentException("Constructing roboMath class failed! The D-H Table is a 4x4 matrix", "T");
            m_AngleUnits = AngleUnitTypes.Radians;
            m_thetaAngles = new double[5];
            m_T = T;
        }

        public roboMath(double[,] T, AngleUnitTypes AnglesUnits)
        {
            if (T.Rank != 2 || (T.GetLength(0) != 4) || (T.GetLength(1) != 4))
                throw new ArgumentException("Constructing roboMath class failed! The D-H Table is a 4x4 matrix", "T");
            m_AngleUnits = AnglesUnits;
            m_thetaAngles = new double[5];
            m_T = T;
        }

        public roboMath(double[,] T, double[] th)
        {
            if (T.Rank != 2 || (T.GetLength(0) != 4) || (T.GetLength(1) != 4))
                throw new ArgumentException("Constructing roboMath class failed! The D-H Table is a 4x4 matrix", "T");
            m_AngleUnits = AngleUnitTypes.Radians;
            m_thetaAngles = new double[5];
            m_T = T;
        }

        public roboMath(double[,] T, double[] th, AngleUnitTypes AnglesUnits)
        {
            if (T.Rank != 2 || (T.GetLength(0) != 4) || (T.GetLength(1) != 4))
                throw new ArgumentException("Constructing roboMath class failed! The D-H Table is a 4x4 matrix", "T");
            if (th.Length != 5)
                throw new ArgumentException("Constructing roboMath class failed! The theta angles given must be an array of 5 doubles", "th");
            m_AngleUnits = AnglesUnits;
            m_thetaAngles = th;
            m_T = T;
        }
        #endregion

        #region Mathematic Functions 
        //Movement equations have been solved. Using the
        //results, one can calculate the position of the
        //end of the robot (if angles of arms are given)
        //or the angles at which the arms have to be, to
        //have the final arm at a specific point.

        #region Transformation Functions

        /// <summary>
        /// Calculates the 3x3 transformation matrix for rotating the coordinates' system around x axis by theta radians.
        /// </summary>
        public static double[,] RotateAxisX(double theta)
        {
            return new double[,] { { 1, 0, 0 }, { 0, Math.Cos(theta), -Math.Sin(theta) }, { 0, Math.Sin(theta), Math.Cos(theta) } };
        }

        /// <summary>
        /// Calculates the 3x3 transformation matrix for rotating the coordinates' system around x axis by theta radians/degrees.
        /// Whether the angles are measured in radians or in degrees depends on the second parameter.
        /// </summary>
        public static double[,] RotateAxisX(double theta, AngleUnitTypes AnglesUnits)
        {
            if (AnglesUnits == AngleUnitTypes.Degrees)
                theta *= Math.PI / 180;
            return RotateAxisX(theta);
        }

        /// <summary>
        /// Calculates the 3x3 transformation matrix for rotating the coordinates' system around y axis by theta radians.
        /// </summary>
        public static double[,] RotateAxisY(double theta)
        {
            return new double[,] { { Math.Cos(theta), 0, Math.Sin(theta) }, { 0, 1, 0 }, { -Math.Sin(theta), 0, Math.Cos(theta) } };
        }

        /// <summary>
        /// Calculates the 3x3 transformation matrix for rotating the coordinates' system around y axis by theta radians/degrees.
        /// Whether the angles are measured in radians or in degrees depends on the second parameter.
        /// </summary>
        public static double[,] RotateAxisY(double theta, AngleUnitTypes AnglesUnits)
        {
            if (AnglesUnits == AngleUnitTypes.Degrees)
                theta *= Math.PI / 180;
            return RotateAxisY(theta);
        }

        /// <summary>
        /// Calculates the 3x3 transformation matrix for rotating the coordinates' system around z axis by theta radians.
        /// </summary>
        public static double[,] RotateAxisZ(double theta)
        {
            return new double[,] { { Math.Cos(theta), -Math.Sin(theta), 0 }, { Math.Sin(theta), Math.Cos(theta), 0 }, { 0, 0, 1 } };
        }

        /// <summary>
        /// Calculates the 3x3 transformation matrix for rotating the coordinates' system around z axis by theta radians/degrees.
        /// Whether the angles are measured in radians or in degrees depends on the second parameter.
        /// </summary>
        public static double[,] RotateAxisZ(double theta, AngleUnitTypes AnglesUnits)
        {
            if (AnglesUnits == AngleUnitTypes.Degrees)
                theta *= Math.PI / 180;
            return RotateAxisZ(theta);
        }

        /// <summary>
        /// Calculates the 4x4 transformation matrix for moving the coordinates' system along x axis by a.
        /// </summary>
        public static double[,] TransposeAxisX(double a)
        {
            return new double[,] { { 1, 0, 0, a }, { 0, 1, 0, 0 }, { 0, 0, 1, 0 }, { 0, 0, 0, 1 } };
        }

        /// <summary>
        /// Calculates the 4x4 transformation matrix for moving the coordinates' system along y axis by b.
        /// </summary>
        public static double[,] TransposeAxisY(double b)
        {
            return new double[,] { { 1, 0, 0, 0 }, { 0, 1, 0, b }, { 0, 0, 1, 0 }, { 0, 0, 0, 1 } };
        }

        /// <summary>
        /// Calculates the 4x4 transformation matrix for moving the coordinates' system along z axis by c.
        /// </summary>
        public static double[,] TransposeAxisZ(double c)
        {
            return new double[,] { { 1, 0, 0, 0 }, { 0, 1, 0, 0 }, { 0, 0, 1, c }, { 0, 0, 0, 1 } };
        }

        /// <summary>
        /// Calculates the 4x4 Denavit-Hartenberg transformation matrix. Angles are measured in radians.
        /// </summary>
        public static double[,] DH(double a, double alpha, double d, double theta)
        {
            double[,] retval = {{Math.Cos(theta), -Math.Sin(theta)*Math.Cos(alpha),  Math.Sin(theta)*Math.Sin(alpha), a*Math.Cos(theta)},
                               { Math.Sin(theta),  Math.Cos(theta)*Math.Cos(alpha), -Math.Cos(theta)*Math.Sin(alpha), a*Math.Sin(theta)},
                               {               0,                  Math.Sin(alpha),                  Math.Cos(alpha),                 d},
                               {               0,                                0,                                0,                 1}};
            return retval;
        }

        /// <summary>
        /// Calculates the 4x4 Denavit-Hartenberg transformation matrix.
        /// Whether the angles are measured in radians or in degrees depends on the last parameter.
        /// </summary>
        public static double[,] DH(double a, double alpha, double d, double theta, AngleUnitTypes AnglesUnits)
        {
            if (AnglesUnits == AngleUnitTypes.Degrees)
            {
                alpha *= Math.PI / 180;
                theta *= Math.PI / 180;
            }
            return DH(a, alpha, d, theta);
        }
        #endregion

        #region Functions for the Direct Kinematics Solving Problem.
        #region Function getXYZ (Find Joint Position from angles)
        /// <summary>
        /// Calculate joint position function using vectors - Returns 1x3 matrix.
        /// n is the number of the joint whose position you want to find.
        /// The angles are measured in radians by default.
        /// </summary>
        public static double[] getXYZ(int n, double th1, double th2, double th3, double th4, double th5, AngleUnitTypes AnglesUnits)
        {
            if (AnglesUnits == AngleUnitTypes.Degrees)
            {
                th1 *= Math.PI / 180;
                th2 *= Math.PI / 180;
                th3 *= Math.PI / 180;
                th4 *= Math.PI / 180;
            }
            int[] l = new int[5];
            for (int i = 0; i < n; ++i)
                l[i] = link[i];

            double th23 = th2 + th3;
            double x = l[1] * Math.Cos(th2) + l[2] * Math.Cos(th23) + (l[3] + l[4]) * Math.Cos(th23 + th4);
            double z = l[0] + l[1] * Math.Sin(th2) + l[2] * Math.Sin(th23) + (l[3] + l[4]) * Math.Sin(th23 + th4);
            return new double[] { x * Math.Cos(th1), x * Math.Sin(th1), z };
        }

        /// <summary>
        /// Calculate joint position function using vectors - Returns 1x3 matrix.
        /// n is the number of the joint whose position you want to find.
        /// The angles are measured in radians by default.
        /// </summary>
        public static double[] getXYZ(int n, double th1, double th2, double th3, double th4, double th5)
        {
            return getXYZ(n, th1, th2, th3, th4, 69, AngleUnitTypes.Radians);
        }

        /// <summary>
        /// Calculate joint position function using vectors - Returns 1x3 matrix.
        /// n is the number of the joint whose position you want to find.
        /// Whether the angles are measured in radians or in degrees depends on the value of the last parameter.
        /// </summary>
        public static double[] getXYZ(int n, double th1, double th2, double th3, double th4)
        {
            return getXYZ(n, th1, th2, th3, th4, 69, AngleUnitTypes.Radians);
        }

        /// <summary>
        /// Calculate joint position function - Returns 1x3 matrix.
        /// n is the number of the joint whose position you want to find.
        /// The angles are measured in radians by default.
        /// </summary>
        public static double[] getXYZ(int n, double[] th)
        {
            return getXYZ(n, th[0], th[1], th[2], th[3], 69, AngleUnitTypes.Radians);
        }

        /// <summary>
        /// Calculate joint position function - Returns 1x3 matrix.
        /// n is the number of the joint whose position you want to find.
        /// Whether the angles are measured in radians or in degrees depends on the value of the last parameter.
        /// </summary>
        public static double[] getXYZ(int n, double[] th, AngleUnitTypes AnglesUnits)
        {
            return getXYZ(n, th[0], th[1], th[2], th[3], 69, AnglesUnits);
        }

        /// <summary>
        /// Calculate joint position function - Returns 1x3 matrix.
        /// n is the number of the joint whose position you want to find.
        /// Whether the angles' values that are stored in the object are measured in radians or in degrees
        /// depends on the value of AngleUnits which is radians by default.
        /// </summary>
        public double[] getXYZ(int n)
        {
            return getXYZ(n, m_thetaAngles[0], m_thetaAngles[1], m_thetaAngles[2], m_thetaAngles[3], 69, m_AngleUnits);
        }

        #endregion

        #region Function getOrient (Find Tool's orientation from angles)
        /// <summary>
        /// Calculate tool orientation function.
        /// The angles are measured in radians by default.
        /// </summary>
        public static double[] getOrient(double th1, double th2, double th3, double th4, double th5, AngleUnitTypes AnglesUnits)
        {
            if (AnglesUnits == AngleUnitTypes.Degrees)
            {
                th1 *= Math.PI / 180;
                th2 *= Math.PI / 180;
                th3 *= Math.PI / 180;
                th4 *= Math.PI / 180;
            }
            double th234 = th2 + th3 + th4;
            double x_t = Math.Cos(th234) * Math.Cos(th1);
            double y_t = Math.Cos(th234) * Math.Sin(th1);
            double z_t = Math.Sin(th234);
            return new double[] { x_t, y_t, z_t };
        }

        /// <summary>
        /// Calculate tool orientation function.
        /// Whether the angles are measured in radians or in degrees depends on the value of the last parameter.
        /// </summary>
        public static double[] getOrient(double th1, double th2, double th3, double th4, double th5)
        {
            return getOrient(th1, th2, th3, th4, th5, AngleUnitTypes.Radians);
        }

        /// <summary>
        /// Calculate tool orientation function.
        /// The angles are measured in radians by default.
        /// </summary>
        public static double[] getOrient(double th1, double th2, double th3, double th4)
        {
            return getOrient(th1, th2, th3, th4, 69, AngleUnitTypes.Radians);
        }

        /// <summary>
        /// Calculate tool orientation function.
        /// The angles are measured in radians by default.
        /// </summary>
        public static double[] getOrient(double[] th)
        {
            return getOrient(th[0], th[1], th[2], th[3], 69, AngleUnitTypes.Radians);
        }

        /// <summary>
        /// Calculate tool orientation function.
        /// Whether the angles are measured in radians or in degrees depends on the value of the last parameter.
        /// </summary>
        public static double[] getOrient(double[] th, AngleUnitTypes AnglesUnits)
        {
            return getOrient(th[0], th[1], th[2], th[3], 69, AnglesUnits);
        }

        /// <summary>
        /// Calculate tool orientation function.
        /// The angles as well as the unit in which they are measured (degrees or radians) are stored inside the class object.
        /// </summary>
        public double[] getOrient()
        {
            return getOrient(m_thetaAngles[0], m_thetaAngles[1], m_thetaAngles[2], m_thetaAngles[3], 69, m_AngleUnits);
        }

        #endregion

        #region Function getDH (Finds D-H Matrix from angles)
        /// <summary>
        /// Calculates the 4x4 Denavit-Hartenberg table that defines both the position and the orientation of the robotic tool
        /// The angles are measured in radians by default.
        /// Returns 4x4 matrix.
        /// </summary>
        public static double[,] getDH(double th1, double th2, double th3, double th4, double th5)
        {
            double th234 = th2 + th3 + th4;
            double[,] retval = {{ Math.Sin(th1)*Math.Sin(th5) - Math.Cos(th1)*Math.Cos(th5)*Math.Sin(th234),  Math.Sin(th1)*Math.Cos(th5) + Math.Cos(th1)*Math.Sin(th5)*Math.Sin(th234), Math.Cos(th1)*Math.Cos(th234), Math.Cos(th1)*( (link[4]+link[3])*Math.Cos(th234) + link[2]*Math.Cos(th3+th2) + link[1]*Math.Cos(th2) )},
                                {-Math.Cos(th1)*Math.Sin(th5) - Math.Sin(th1)*Math.Cos(th5)*Math.Sin(th234), -Math.Cos(th1)*Math.Cos(th5) + Math.Sin(th1)*Math.Sin(th5)*Math.Sin(th234), Math.Sin(th1)*Math.Cos(th234), Math.Sin(th1)*( (link[4]+link[3])*Math.Cos(th234) + link[2]*Math.Cos(th3+th2) + link[1]*Math.Cos(th2) )},
                                {                                             Math.Cos(th5)*Math.Cos(th234),                                             -Math.Sin(th5)*Math.Cos(th234),               Math.Sin(th234),       link[0] + (link[4]+link[3])*Math.Sin(th234) + link[2]*Math.Sin(th3+th2) + link[1]*Math.Sin(th2)  },
                                {                                                                         0,                                                                          0,                             0,                                                                                                       1}};
            return retval;
        }

        /// <summary>
        /// Calculates the 4x4 Denavit-Hartenberg table that defines both the position and the orientation of the robotic tool
        /// Whether the angles are measured in radians or in degrees depends on the value of the last parameter.
        /// Returns 4x4 matrix.
        /// </summary>
        public static double[,] getDH(double th1, double th2, double th3, double th4, double th5, AngleUnitTypes AnglesUnits)
        {
            if (AnglesUnits == AngleUnitTypes.Degrees)
            {
                th1 *= Math.PI / 180;
                th2 *= Math.PI / 180;
                th3 *= Math.PI / 180;
                th4 *= Math.PI / 180;
                th5 *= Math.PI / 180;
            }
            return getDH(th1, th2, th3, th4, th5);
        }

        /// <summary>
        /// Calculates the 4x4 Denavit-Hartenberg table that defines both the position and the orientation of the robotic tool
        /// The angles are measured in radians by default.
        /// Returns 4x4 matrix.
        /// </summary>
        public static double[,] getDH(double[] th)
        {
            return getDH(th[0], th[1], th[2], th[3], th[4]);
        }

        /// <summary>
        /// Calculates the 4x4 Denavit-Hartenberg table that defines both the position and the orientation of the robotic tool
        /// Whether the angles are measured in radians or in degrees depends on the value of the last parameter.
        /// Returns 4x4 matrix.
        /// </summary>
        public static double[,] getDH(double[] th, AngleUnitTypes AnglesUnits)
        {
            return getDH(th[0], th[1], th[2], th[3], th[4], AnglesUnits);
        }

        /// <summary>
        /// Calculates the 4x4 Denavit-Hartenberg table that defines both the position and the orientation of the robotic tool.
        /// The angles as well as the unit in which they are measured (degrees or radians) are stored inside the class object.
        /// Returns 4x4 matrix.
        /// </summary>
        public double[,] getDH()
        {
            return getDH(m_thetaAngles[0], m_thetaAngles[1], m_thetaAngles[2], m_thetaAngles[3], m_thetaAngles[4], m_AngleUnits);
        }

        #endregion

        #region Function CalculateDH ((Finds D-H Matrix from angles))
        public static double[,] calculateDH(double th1, double th2, double th3, double th4, double th5)
        {
	    //Calculate the "A" matrices. One matrix for each DOF
            double[][,] A = new double[5][,];
            A[0] = DH(0, Math.PI / 2, link[0], th1);
            A[1] = DH(link[1], 0, 0, th2); //Careful: th2 was Math.PI/2-th2 
            A[2] = DH(link[2], 0, 0, th3);
            A[3] = DH(0, Math.PI / 2, 0, th4 + Math.PI / 2);
            A[4] = DH(0, 0, link[3] + link[4], th5);

            GeneralMatrix table1 = A[0];
            for (int i = 1; i < 5; ++i)
                table1 *= A[i];
            return table1.ToDoubleArray();
        }

        public static double[,] calculateDH(double th1, double th2, double th3, double th4, double th5, AngleUnitTypes AnglesUnits)
        {
            if (AnglesUnits == AngleUnitTypes.Degrees)
            {
                th1 *= Math.PI / 180;
              //  th2 -= 90;
                th2 *= Math.PI / 180;
                th3 *= Math.PI / 180;
                th4 *= Math.PI / 180;
                th5 *= Math.PI / 180;
            }
            return calculateDH(th1, th2, th3, th4, th5);
        }

        public static double[,] calculateDH(double[] th, AngleUnitTypes AnglesUnits)
        {
            return calculateDH(th[0], th[1], th[2], th[3], th[4], AnglesUnits);
        }

        public static double[,] calculateDH(double[] th)
        {
            return calculateDH(th[0], th[1], th[2], th[3], th[4]);
        }

        public double[,] calculateDH()
        {
            return calculateDH(m_thetaAngles[0], m_thetaAngles[1], m_thetaAngles[2], m_thetaAngles[3], m_thetaAngles[4], m_AngleUnits);
        }

        #endregion

        #region Function calculateJointPosDH (Finds Joints positions and returns the table pd from the angles)
        public static double[][] calculateJointPosDH(double th1, double th2, double th3, double th4, double th5)
        {
            double[][,] A = new double[5][,];
            A[0] = DH(0, Math.PI / 2, link[0], th1);
            A[1] = DH(link[1], 0, 0, th2);
            A[2] = DH(link[2], 0, 0, th3);
            A[3] = DH(0, Math.PI / 2, 0, th4 + Math.PI / 2);
            A[4] = DH(0, 0, link[3] + link[4], th5);

            double[][] pd = new double[11][];
            pd[0] = new double[3];
            GeneralMatrix table1 = GeneralMatrix.Identity(4);
            for (int i = 0; i < 5; )
            {
                table1 *= A[i++];
                pd[i] = new double[3] { table1[0, 3], table1[1, 3], table1[2, 3] };
            }
            for (int i = 0; i < 3; ++i)
                pd[2 * i + 6] = 100 * GeneralMatrix.FromArrayVertical(new double[3] { table1[0, i], table1[1, i], table1[2, i] }) + pd[5];
            pd[7] = pd[9] = pd[5];
            return pd;
        }

        public static double[][] calculateJointPosDH(double th1, double th2, double th3, double th4, double th5, AngleUnitTypes AnglesUnits)
        {
            if (AnglesUnits == AngleUnitTypes.Degrees)
            {
                th1 *= Math.PI / 180;
                th2 *= Math.PI / 180;
                th3 *= Math.PI / 180;
                th4 *= Math.PI / 180;
                th5 *= Math.PI / 180;
            }
            return calculateJointPosDH(th1, th2, th3, th4, th5);
        }

        public static double[][] calculateJointPosDH(double[] th, AngleUnitTypes AnglesUnits)
        {
            return calculateJointPosDH(th[0], th[1], th[2], th[3], th[4], AnglesUnits);
        }

        public static double[][] calculateJointPosDH(double[] th)
        {
            return calculateJointPosDH(th[0], th[1], th[2], th[3], th[4]);
        }

        public double[][] calculateJointPosDH()
        {
            return calculateJointPosDH(m_thetaAngles[0], m_thetaAngles[1], m_thetaAngles[2], m_thetaAngles[3], m_thetaAngles[4], m_AngleUnits);
        }

        #endregion

        #region Function calculateJointPos (Finds Joints positions and returns the table pd from the angles)
        public static double[][] calculateJointPos(double th1, double th2, double th3, double th4, double th5)
        {
            double[][] p = new double[10][];
            p[0] = new double[3];
            for (int i = 1; i < 6; ++i)
                p[i] = getXYZ(i, th1, th2, th3, th4, th5);

            double th234 = th2 + th3 + th4;
            p[6] = GeneralMatrix.ToArray(GeneralMatrix.FromArray(new double[3] { 0, 100, 0 }) * RotateAxisX(-th5) * RotateAxisY(th234) * RotateAxisZ(-th1) + GeneralMatrix.FromArray(p[5]));
            p[7] = GeneralMatrix.ToArray(GeneralMatrix.FromArray(new double[3] { 0, -100, 0 }) * RotateAxisX(-th5) * RotateAxisY(th234) * RotateAxisZ(-th1) + GeneralMatrix.FromArray(p[5]));
            p[8] = p[5];
            p[9] = GeneralMatrix.ToArray(GeneralMatrix.FromArray(new double[3] { 100, 0, 0 }) * RotateAxisX(-th5) * RotateAxisY(th234) * RotateAxisZ(-th1) + GeneralMatrix.FromArray(p[5]));
            return p;
        }

        public static double[][] calculateJointPos(double th1, double th2, double th3, double th4, double th5, AngleUnitTypes AnglesUnits)
        {
            if (AnglesUnits == AngleUnitTypes.Degrees)
            {
                th1 *= Math.PI / 180;
                th2 *= Math.PI / 180;
                th3 *= Math.PI / 180;
                th4 *= Math.PI / 180;
                th5 *= Math.PI / 180;
            }
            return calculateJointPos(th1, th2, th3, th4, th5);
        }

        public static double[][] calculateJointPos(double[] th, AngleUnitTypes AnglesUnits)
        {
            return calculateJointPos(th[0], th[1], th[2], th[3], th[4], AnglesUnits);
        }

        public static double[][] calculateJointPos(double[] th)
        {
            return calculateJointPos(th[0], th[1], th[2], th[3], th[4]);
        }

        public double[][] calculateJointPos()
        {
            return calculateJointPos(m_thetaAngles[0], m_thetaAngles[1], m_thetaAngles[2], m_thetaAngles[3], m_thetaAngles[4], m_AngleUnits);
        }

        #endregion
        #endregion

        #region Functions for the Inverse Kinematics Solving Problem.
        #region Function CalculateReverse (Finds angles from D-H Matrix)
        private static double[][] CalculateReverse(double[,] T, bool Debug)
        {
            if ((T.Rank != 2) || (T.GetLength(0) != 4) || (T.GetLength(1) != 4))
                throw new ArgumentException("Table T is the D-H Matrix, so it must be a 4x4 dimension array", "T");

            double px = T[0, 3] - (link[3] + link[4]) * T[0, 2];
            double py = T[1, 3] - (link[3] + link[4]) * T[1, 2];
            double pz = T[2, 3] - (link[3] + link[4]) * T[2, 2];
            if (Debug == true) Console.WriteLine("\np(x,y,z) = (" + px.ToString("F3") + " , " + py.ToString("F3") + " , " + pz.ToString("F3") + ")");

            double D = (Math.Pow(px, 2) + Math.Pow(py, 2) + Math.Pow(pz - link[0], 2) - Math.Pow(link[1], 2) - Math.Pow(link[2], 2)) / 2 / link[1] / link[2];
            double[][] theta = new double[4][];
            for (int i = 0, m = 0; i <= 1; ++i) //Two solution sets: front and back (in accordance to x axis)
                for (int k = -1; k <= 1; k += 2) //Two solutions: elbow up and elbow down
                {
                    double f1 = Math.Atan2(py, px) + i * Math.PI;
                    // TODO: Investigate Math.Abs usage (D?)
                    double f3 = Math.Atan2(k * Math.Sqrt(Math.Abs(1 - D*D)), D);
                    double f2 = Math.Atan2(pz - link[0], Math.Sqrt(px*px + py*py)) - Math.Atan2(link[2] * Math.Sin(f3), link[1] + link[2] * Math.Cos(f3));
                    if (i == 1)
                    {
                        f2 = Math.PI - f2;
                        f3 = -f3;
                    }
                    double f23 = f2 + f3;
                    double f4 = Math.Atan2(Math.Cos(f23) * T[2, 2] - Math.Sin(f1) * T[1, 2] * Math.Sin(f23) - Math.Cos(f1) * Math.Sin(f23) * T[0, 2], Math.Sin(f23) * T[2, 2] + Math.Sin(f1) * T[1, 2] * Math.Cos(f23) + Math.Cos(f1) * T[0, 2] * Math.Cos(f23));
                    double f5 = Math.Atan2(Math.Sin(f1) * T[0, 0] - Math.Cos(f1) * T[1, 0], Math.Sin(f1) * T[0, 1] - Math.Cos(f1) * T[1, 1]);

                    theta[m++] = new double[5] { f1, f2, f3, f4, f5 };
                }
            return theta;
        }

        private static double[][] CalculateReverse(double[][] T, bool Debug)
        {
            int TLength0 = T.Length;
            int TLength1 = T[0].Length;
            for (int i = 1; i < TLength0; ++i)
                if (T[i].Length != TLength1)
                    throw new ArgumentException("The parameter array (T) must have the same number of columns for each row.", "T");
            double[,] mRet = new double[TLength0, TLength1];
            for (int i = 0; i < TLength0; ++i)
                for (int j = 0; j < TLength1; ++j)
                    mRet[i, j] = T[i][j];
            return CalculateReverse(mRet, Debug);
        }

        public static double[][] CalculateReverse(double[,] T)
        {
            return CalculateReverse(T, false);
        }

        public static double[][] CalculateReverse(double[,] T, AngleUnitTypes AnglesUnits)
        {
            if (AnglesUnits == AngleUnitTypes.Degrees)
                return convertRadtoDegrees(CalculateReverse(T, false));
            else return CalculateReverse(T, false);
        }

        public static double[][] CalculateReverse(double[][] T)
        {
            return CalculateReverse(T, false);
        }

        public static double[][] CalculateReverse(double[][] T, AngleUnitTypes AnglesUnits)
        {
            if (AnglesUnits == AngleUnitTypes.Degrees)
                return convertRadtoDegrees(CalculateReverse(T, false));
            else return CalculateReverse(T, false);
        }

        public double[][] CalculateReverse()
        {
            if (m_AngleUnits == AngleUnitTypes.Degrees)
                
                return convertRadtoDegrees(CalculateReverse(m_T, false));
            else return CalculateReverse(m_T, false);
        }

        #endregion

        #endregion

        #region Helper Functions
        public static double convertRadtoDegrees(int th)
        {
            return th * 180 / Math.PI;
        }

        public static double convertRadtoDegrees(double th)
        {
            return th * 180 / Math.PI;
        }

        public static double[] convertRadtoDegrees(double[] th)
        {
            for (int i = 0; i < th.Length; ++i)
                th[i] *= 180 / Math.PI;
            return th;
        }

        public static double[][] convertRadtoDegrees(double[][] th)
        {
            for (int i = 0; i < th.Length; ++i)
                for (int j = 0; j < th[i].Length; ++j)
                    th[i][j] *= 180 / Math.PI;
            return th;
        }

        public static double[,] convertRadtoDegrees(double[,] th)
        {
            for (int i = 0; i < th.GetLength(0); ++i)
                for (int j = 0; j < th.GetLength(1); ++j)
                    th[i, j] *= 180 / Math.PI;
            return th;
        }

        public static double convertDegreestoRad(int th)
        {
            return th * Math.PI / 180;
        }

        public static double convertDegreestoRad(double th)
        {
            return th * Math.PI / 180;
        }

        public static double[] convertDegreestoRad(double[] th)
        {
            for (int i = 0; i < th.Length; ++i)
                th[i] *= Math.PI / 180;
            return th;
        }

        public static double[][] convertDegreestoRad(double[][] th)
        {
            for (int i = 0; i < th.Length; ++i)
                for (int j = 0; j < th[i].Length; ++j)
                    th[i][j] *= Math.PI / 180;
            return th;
        }

        public static double[,] convertDegreestoRad(double[,] th)
        {
            for (int i = 0; i < th.GetLength(0); ++i)
                for (int j = 0; j < th.GetLength(1); ++j)
                    th[i, j] *= Math.PI / 180;
            return th;
        }
        #endregion

        #region Functions for testing all the math functions.
        public static void testMathFunctions(double th1, double th2, double th3, double th4, double th5, AngleUnitTypes AnglesUnits)
        {
            Console.WriteLine("\nData Entered for TestingFunction: ");
            Console.WriteLine("\tth1 = " + th1.ToString("F3") + " " + AnglesUnits.ToString() + "\n\tth2 = " + th2.ToString("F3") + " " + AnglesUnits.ToString() + "\n\tth3 = " + th3.ToString("F3") + " " + AnglesUnits.ToString());
            Console.WriteLine("\tth4 = " + th4.ToString("F3") + " " + AnglesUnits.ToString() + "\n\tth5 = " + th5.ToString("F3") + " " + AnglesUnits.ToString());

            if (AnglesUnits == AngleUnitTypes.Degrees)
            {
                th1 *= Math.PI / 180;
                th2 *= Math.PI / 180;
                th3 *= Math.PI / 180;
                th4 *= Math.PI / 180;
                th5 *= Math.PI / 180;
            }

            Console.WriteLine("\n\n\n   #####  DIRECT KINEMATICS  #####");

            double[][] p = calculateJointPos(th1, th2, th3, th4, th5);
            double[][] pd = calculateJointPosDH(th1, th2, th3, th4, th5);

            double[] t_pos = p[5];
            double[] t_orient = getOrient(th1, th2, th3, th4, th5);

            Console.WriteLine("\n* Calculate joint positions using vectors:");
            for (int i = 1; i < 6; ++i)
                Console.WriteLine("   Joint " + i + " Position:\t" + p[i][0].ToString("F3") + "\t" + p[i][1].ToString("F3") + "\t" + p[i][2].ToString("F3"));
            Console.WriteLine("\nTool position: \tx = " + t_pos[0].ToString("F3") + "\ty = " + t_pos[1].ToString("F3") + "\tz = " + t_pos[2].ToString("F3"));
            Console.WriteLine("Tool (a) axis: \tx = " + t_orient[0].ToString("F3") + "\ty = " + t_orient[1].ToString("F3") + "\tz = " + t_orient[2].ToString("F3"));

            Console.WriteLine("\n* Denavit-Hartenberg calculation:");
            for (int i = 1; i < 6; ++i)
                Console.WriteLine("   Joint " + i + " Position:\t" + pd[i][0].ToString("F3") + "\t" + pd[i][1].ToString("F3") + "\t" + pd[i][2].ToString("F3"));

            Console.WriteLine("\n* DH transformation matrix");
            double[,] table1 = calculateDH(th1, th2, th3, th4, th5);
            for (int i = 0; i < 4; ++i)
                Console.WriteLine("\t" + table1[i, 0].ToString("F3") + "\t" + table1[i, 1].ToString("F3") + "\t" + table1[i, 2].ToString("F3") + "\t" + table1[i, 3].ToString("F3"));

            Console.WriteLine("\n* DH function result");
            table1 = getDH(th1, th2, th3, th4, th5);
            for (int i = 0; i < 4; ++i)
                Console.WriteLine("\t" + table1[i, 0].ToString("F3") + "\t" + table1[i, 1].ToString("F3") + "\t" + table1[i, 2].ToString("F3") + "\t" + table1[i, 3].ToString("F3"));

            Console.WriteLine("\n\n   #####  INVERSE KINEMATICS  #####");
            double[][] thet = CalculateReverse(table1, true);
            for (int i = 0; i < thet.Length; ++i)
            {
                if (AnglesUnits == AngleUnitTypes.Degrees)
                    Console.WriteLine("\nf1  = " + convertRadtoDegrees(thet[i][0]).ToString("F3") + "\t2  = " + convertRadtoDegrees(thet[i][1]).ToString("F3") + "\tf3  = " + convertRadtoDegrees(thet[i][2]).ToString("F3") + "\tf4  = " + convertRadtoDegrees(thet[i][3]).ToString("F3") + "\tf5  = " + convertRadtoDegrees(thet[i][4]).ToString("F3"));
                else Console.WriteLine("\nf1  = " + thet[i][0].ToString("F3") + "\t2  = " + thet[i][1].ToString("F3") + "\tf3  = " + thet[i][2].ToString("F3") + "\tf4  = " + thet[i][3].ToString("F3") + "\tf5  = " + thet[i][4].ToString("F3"));
                double[] XYZ = getXYZ(3, thet[i][0], thet[i][1], thet[i][2], thet[i][3], thet[i][4]);
                Console.WriteLine("\n\t[" + XYZ[0].ToString("F3") + ", " + XYZ[1].ToString("F3") + ", " + XYZ[2].ToString("F3") + "]");
                XYZ = getXYZ(5, thet[i][0], thet[i][1], thet[i][2], thet[i][3], thet[i][4]);
                Console.WriteLine("\n\t[" + XYZ[0].ToString("F3") + ", " + XYZ[1].ToString("F3") + ", " + XYZ[2].ToString("F3") + "]");
            }
            Console.WriteLine("\n###########################################################\n\n");
        }

        public static void testMathFunctions(double th1, double th2, double th3, double th4, double th5)
        {
            testMathFunctions(th1, th2, th3, th4, th5, AngleUnitTypes.Radians);
        }

        public static void testMathFunctions(double[] th)
        {
            testMathFunctions(th[0], th[1], th[2], th[3], th[4]);
        }

        public static void testMathFunctions(double[] th, AngleUnitTypes AnglesUnits)
        {
            testMathFunctions(th[0], th[1], th[2], th[3], th[4], AnglesUnits);
        }

        public void testMathFunctions()
        {
            testMathFunctions(m_thetaAngles[0], m_thetaAngles[1], m_thetaAngles[2], m_thetaAngles[3], m_thetaAngles[4], m_AngleUnits);
        }

        #endregion
        #endregion
    }
}
