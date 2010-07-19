using System;
using System.Diagnostics;

//*****************************************************************************************
//                           LICENSE INFORMATION
//*****************************************************************************************
//   5-DOF SolveNMove MatrixManipulation Version 1.0
//   Class file for manipulating matrices
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

namespace MatrixManipulation
{
    public class GeneralMatrix
    {
        private int m_nNumRows = 3;
        private int m_nNumColumns = 3;
        private double[,] m_dValues;

        public GeneralMatrix()
        {
            m_dValues = new double[m_nNumRows, m_nNumColumns];
        }

        public GeneralMatrix(int nNumRows, int nNumColumns)
        {
            m_nNumRows = nNumRows;
            m_nNumColumns = nNumColumns;
            m_dValues = new double[m_nNumRows, m_nNumColumns];
        }

        public double this[int nRow, int nColumn]
        {
            get { return m_dValues[nRow, nColumn]; }
            set { m_dValues[nRow, nColumn] = value; }
        }

        public int NumRows
        {
            get { return m_nNumRows; }
        }

        public int NumColumns
        {
            get { return m_nNumColumns; }
        }

        public GeneralMatrix Clone()
        {
            GeneralMatrix mRet = new GeneralMatrix(m_nNumRows, m_nNumColumns);
            for (int i = 0; i < m_nNumRows; i++)
            {
                for (int j = 0; j < m_nNumColumns; j++)
                {
                    mRet[i, j] = this[i, j];
                }
            }
            return mRet;
        }

        public static GeneralMatrix Identity(int nSize)
        {
            GeneralMatrix mRet = new GeneralMatrix(nSize, nSize);
            for (int i = 0; i < nSize; i++)
            {
                for (int j = 0; j < nSize; j++)
                {
                    mRet[i, j] = (i == j) ? 1.0 : 0.0;
                }
            }
            return mRet;
        }

        public GeneralMatrix Transpose()
        {
            GeneralMatrix mRet = new GeneralMatrix(m_nNumColumns, m_nNumRows);
            for (int i = 0; i < m_nNumRows; i++)
            {
                for (int j = 0; j < m_nNumColumns; j++)
                {
                    mRet[j, i] = this[i, j];
                }
            }
            return mRet;
        }

        public static GeneralMatrix FromArray(double[] dLeft)
        {
            int nLength = dLeft.Length;
            GeneralMatrix mRet = new GeneralMatrix(1, nLength);
            for (int i = 0; i < nLength; i++)
            {
                mRet[0, i] = dLeft[i];
            }
            return mRet;
        }

        public static GeneralMatrix FromArrayVertical(double[] dLeft)
        {
            int nLength = dLeft.Length;
            GeneralMatrix mRet = new GeneralMatrix(nLength, 1);
            for (int i = 0; i < nLength; i++)
            {
                mRet[i, 0] = dLeft[i];
            }
            return mRet;
        }

        public static implicit operator GeneralMatrix(double[] dLeft)
        {
            return FromArrayVertical(dLeft);
        }

        public static GeneralMatrix FromDoubleArray(double[,] dLeft)
        {
            int nLength0 = dLeft.GetLength(0);
            int nLength1 = dLeft.GetLength(1);
            GeneralMatrix mRet = new GeneralMatrix(nLength0, nLength1);
            for (int i = 0; i < nLength0; i++)
            {
                for (int j = 0; j < nLength1; j++)
                {
                    mRet[i, j] = dLeft[i, j];
                }
            }
            return mRet;
        }

        public static implicit operator GeneralMatrix(double[,] dLeft)
        {
            return FromDoubleArray(dLeft);
        }

        public static GeneralMatrix FromDoubleJaggedArray(double[][] dLeft)
        {
            int nLength0 = dLeft.Length;
            int nLength1 = dLeft[0].Length;
            for (int i = 1; i < nLength0; ++i)
                if (dLeft[i].Length != nLength1)
                    throw new ArgumentException("The parameter array (dLeft) must have the same number of columns for each row.", "dLeft");
            GeneralMatrix mRet = new GeneralMatrix(nLength0, nLength1);
            for (int i = 0; i < nLength0; ++i)
                for (int j = 0; j < nLength1; ++j)
                    mRet[i, j] = dLeft[i][j];
            return mRet;
        }

        public static implicit operator GeneralMatrix(double[][] dLeft)
        {
            return FromDoubleJaggedArray(dLeft);
        }

        public static double[] ToArray(GeneralMatrix mLeft)
        {
            Debug.Assert((mLeft.NumColumns == 1 && mLeft.NumRows >= 1) || (mLeft.NumRows == 1 && mLeft.NumColumns >= 1));

            double[] dRet = null;
            if (mLeft.NumColumns > 1)
            {
                int nNumElements = mLeft.NumColumns;
                dRet = new double[nNumElements];
                for (int i = 0; i < nNumElements; i++)
                {
                    dRet[i] = mLeft[0, i];
                }
            }
            else
            {
                int nNumElements = mLeft.NumRows;
                dRet = new double[nNumElements];
                for (int i = 0; i < nNumElements; i++)
                {
                    dRet[i] = mLeft[i, 0];
                }
            }
            return dRet;
        }

        public double[] ToArray()
        {
            return ToArray(this);
        }

        public static implicit operator double[](GeneralMatrix mLeft)
        {
            return ToArray(mLeft);
        }

        public static double[,] ToDoubleArray(GeneralMatrix mLeft)
        {
            double[,] dRet = new double[mLeft.NumRows, mLeft.NumColumns];
            for (int i = 0; i < mLeft.NumRows; i++)
                for (int j = 0; j < mLeft.NumColumns; j++)
                    dRet[i, j] = mLeft[i, j];
            return dRet;
        }

        public double[,] ToDoubleArray()
        {
            return ToDoubleArray(this);
        }

        public static implicit operator double[,](GeneralMatrix mLeft)
        {
            return ToDoubleArray(mLeft);
        }

        public static double[][] ToDoubleJaggedArray(GeneralMatrix mLeft)
        {
            double[][] dRet = new double[mLeft.NumRows][];
            for (int i = 0; i < mLeft.NumRows; ++i)
            {
                dRet[i] = new double[mLeft.NumColumns];
                for (int j = 0; j < mLeft.NumColumns; ++j)
                    dRet[i][j] = mLeft[i, j];
            }
            return dRet;
        }

        public double[][] ToDoubleJaggedArray()
        {
            return ToDoubleJaggedArray(this);
        }

        public static implicit operator double[][](GeneralMatrix mLeft)
        {
            return ToDoubleJaggedArray(mLeft);
        }

        public static GeneralMatrix Add(GeneralMatrix mLeft, GeneralMatrix mRight)
        {
            Debug.Assert(mLeft.NumColumns == mRight.NumColumns);
            Debug.Assert(mLeft.NumRows == mRight.NumRows);

            GeneralMatrix mRet = new GeneralMatrix(mLeft.NumRows, mRight.NumColumns);
            for (int i = 0; i < mLeft.NumRows; i++)
            {
                for (int j = 0; j < mLeft.NumColumns; j++)
                {
                    mRet[i, j] = mLeft[i, j] + mRight[i, j];
                }
            }
            return mRet;
        }

        public static GeneralMatrix operator +(GeneralMatrix mLeft, GeneralMatrix mRight)
        {
            return GeneralMatrix.Add(mLeft, mRight);
        }

        public static GeneralMatrix Subtract(GeneralMatrix mLeft, GeneralMatrix mRight)
        {
            Debug.Assert(mLeft.NumColumns == mRight.NumColumns);
            Debug.Assert(mLeft.NumRows == mRight.NumRows);
            GeneralMatrix mRet = new GeneralMatrix(mLeft.NumRows, mRight.NumColumns);
            for (int i = 0; i < mLeft.NumRows; i++)
            {
                for (int j = 0; j < mLeft.NumColumns; j++)
                {
                    mRet[i, j] = mLeft[i, j] - mRight[i, j];
                }
            }
            return mRet;
        }

        public static GeneralMatrix operator -(GeneralMatrix mLeft, GeneralMatrix mRight)
        {
            return GeneralMatrix.Subtract(mLeft, mRight);
        }

        public static GeneralMatrix Multiply(GeneralMatrix mLeft, GeneralMatrix mRight)
        {
            Debug.Assert(mLeft.NumColumns == mRight.NumRows);
            GeneralMatrix mRet = new GeneralMatrix(mLeft.NumRows, mRight.NumColumns);
            for (int i = 0; i < mRight.NumColumns; i++)
            {
                for (int j = 0; j < mLeft.NumRows; j++)
                {
                    double dValue = 0.0;
                    for (int k = 0; k < mRight.NumRows; k++)
                    {
                        dValue += mLeft[j, k] * mRight[k, i];
                    }
                    mRet[j, i] = dValue;
                }
            }
            return mRet;
        }

        public static GeneralMatrix operator *(GeneralMatrix mLeft, GeneralMatrix mRight)
        {
            return GeneralMatrix.Multiply(mLeft, mRight);
        }

        public static GeneralMatrix Multiply(double dLeft, GeneralMatrix mRight)
        {
            GeneralMatrix mRet = new GeneralMatrix(mRight.NumRows, mRight.NumColumns);
            for (int i = 0; i < mRight.NumRows; i++)
            {
                for (int j = 0; j < mRight.NumColumns; j++)
                {
                    mRet[i, j] = dLeft * mRight[i, j];
                }
            }
            return mRet;
        }

        public static GeneralMatrix operator *(double dLeft, GeneralMatrix mRight)
        {
            return GeneralMatrix.Multiply(dLeft, mRight);
        }

        public static GeneralMatrix Multiply(GeneralMatrix mLeft, double dRight)
        {
            GeneralMatrix mRet = new GeneralMatrix(mLeft.NumRows, mLeft.NumColumns);
            for (int i = 0; i < mLeft.NumRows; i++)
            {
                for (int j = 0; j < mLeft.NumColumns; j++)
                {
                    mRet[i, j] = mLeft[i, j] * dRight;
                }
            }
            return mRet;
        }

        public static GeneralMatrix operator *(GeneralMatrix mLeft, double dRight)
        {
            return GeneralMatrix.Multiply(mLeft, dRight);
        }

        public static GeneralMatrix Divide(GeneralMatrix mLeft, double dRight)
        {
            GeneralMatrix mRet = new GeneralMatrix(mLeft.NumRows, mLeft.NumColumns);
            for (int i = 0; i < mLeft.NumRows; i++)
            {
                for (int j = 0; j < mLeft.NumColumns; j++)
                {
                    mRet[i, j] = mLeft[i, j] / dRight;
                }
            }
            return mRet;
        }

        public static GeneralMatrix operator /(GeneralMatrix mLeft, double dRight)
        {
            return GeneralMatrix.Divide(mLeft, dRight);
        }

        public GeneralMatrix SolveFor(GeneralMatrix mRight)
        {
            Debug.Assert(mRight.NumRows == m_nNumColumns);
            Debug.Assert(m_nNumColumns == m_nNumRows);
            GeneralMatrix mRet = new GeneralMatrix(m_nNumColumns, mRight.NumColumns);

            LUDecompositionResults resDecomp = LUDecompose();
            int[] nP = resDecomp.PivotArray;
            GeneralMatrix mL = resDecomp.L;
            GeneralMatrix mU = resDecomp.U;

            double dSum = 0.0;

            for (int k = 0; k < mRight.NumColumns; k++)
            {
                //Solve for the corresponding d Matrix from Ld=Pb
                GeneralMatrix D = new GeneralMatrix(m_nNumRows, 1);
                D[0, 0] = mRight[nP[0], k] / mL[0, 0];
                for (int i = 1; i < m_nNumRows; i++)
                {
                    dSum = 0.0;
                    for (int j = 0; j < i; j++)
                    {
                        dSum += mL[i, j] * D[j, 0];
                    }
                    D[i, 0] = (mRight[nP[i], k] - dSum) / mL[i, i];
                }

                //Solve for x using Ux = d
                //DMatrix X = new DMatrix(m_nNumRows, 1);
                mRet[m_nNumRows - 1, k] = D[m_nNumRows - 1, 0];
                for (int i = m_nNumRows - 2; i >= 0; i--)
                {
                    dSum = 0.0;
                    for (int j = i + 1; j < m_nNumRows; j++)
                    {
                        dSum += mU[i, j] * mRet[j, k];

                    }
                    mRet[i, k] = D[i, 0] - dSum;
                }
            }

            return mRet;
        }

        private LUDecompositionResults LUDecompose()
        {
            Debug.Assert(m_nNumColumns == m_nNumRows);
            // Using Crout Decomp with P
            //
            //  Ax = b   //By definition of problem variables.
            //
            //  LU = PA   //By definition of L, U, and P.
            //
            //  LUx = Pb  //By substition for PA.
            //
            //  Ux = d   //By definition of d
            //
            //  Ld = Pb   //By subsitition for d.
            //
            //For 4x4 with P = I
            //  [l11 0   0   0  ]  [1 u12 u13 u14]   [a11 a12 a13 a14]
            //  [l21 l22 0   0  ]  [0 1   u23 u24] = [a21 a22 a23 a24]
            //  [l31 l32 l33 0  ]  [0 0   1   u34]   [a31 a32 a33 a34]
            //  [l41 l42 l43 l44]  [0 0   0   1  ]   [a41 a42 a43 a44]

            LUDecompositionResults resRet = new LUDecompositionResults();
            int[] nP = new int[m_nNumRows]; //Pivot matrix.
            GeneralMatrix mU = new GeneralMatrix(m_nNumRows, m_nNumColumns);
            GeneralMatrix mL = new GeneralMatrix(m_nNumRows, m_nNumColumns);
            GeneralMatrix mUWorking = Clone();
            GeneralMatrix mLWorking = new GeneralMatrix(m_nNumRows, m_nNumColumns);
            for (int i = 0; i < m_nNumRows; i++)
            {
                nP[i] = i;
            }

            //Iterate down the number of rows in the U matrix.
            for (int i = 0; i < m_nNumRows; i++)
            {
                //Do pivots first.
                //I want to make the matrix diagnolaly dominate.

                //Initialize the variables used to determine the pivot row.
                double dMaxRowRatio = double.NegativeInfinity;
                int nMaxRow = -1;
                int nMaxPosition = -1;
                //Check all of the rows below and including the current row
                //to determine which row should be pivoted to the working row position.
                //The pivot row will be set to the row with the maximum ratio
                //of the absolute value of the first column element divided by the
                //sum of the absolute values of the elements in that row.

                for (int j = i; j < m_nNumRows; j++)
                {
                    //Store the sum of the absolute values of the row elements in
                    //dRowSum.  Clear it out now because I am checking a new row.
                    double dRowSum = 0.0;
                    //Go across the columns, add the absolute values of the elements in
                    //that column to dRowSum.
                    for (int k = i; k < m_nNumColumns; k++)
                    {
                        dRowSum += Math.Abs(mUWorking[nP[j], k]);
                    }

                    //Check to see if the absolute value of the ratio of the lead
                    //element over the sum of the absolute values of the elements is larger
                    //that the ratio for preceding rows.  If it is, then the current row
                    //becomes the new pivot candidate.
                    if (Math.Abs(mUWorking[nP[j], i] / dRowSum) > dMaxRowRatio)
                    {
                        dMaxRowRatio = Math.Abs(mUWorking[nP[j], i] / dRowSum);
                        nMaxRow = nP[j];
                        nMaxPosition = j;
                    }
                }

                //If the pivot candidate isn't the current row, update the
                //pivot array to swap the current row with the pivot row.
                if (nMaxRow != nP[i])
                {
                    int nHold = nP[i];
                    nP[i] = nMaxRow;
                    nP[nMaxPosition] = nHold;
                }

                //Store the value of the left most element in the working U
                //matrix in dRowFirstElementValue.
                double dRowFirstElementValue = mUWorking[nP[i], i];
                //Update the columns of the working row.  j is the column index.
                for (int j = 0; j < m_nNumRows; j++)
                {
                    if (j < i)
                    {
                        //If j<1, then the U matrix element value is 0.
                        mUWorking[nP[i], j] = 0.0;
                    }
                    else if (j == i)
                    {
                        //If i == j, the L matrix value is the value of the
                        //element in the working U matrix.
                        mLWorking[nP[i], j] = dRowFirstElementValue;
                        //The value of the U matrix for i == j is 1
                        mUWorking[nP[i], j] = 1.0;
                    }
                    else // j>i
                    {
                        //Divide each element in the current row of the U matrix by the
                        //value of the first element in the row
                        mUWorking[nP[i], j] /= dRowFirstElementValue;
                        //The element value of the L matrix for j>i is 0
                        mLWorking[nP[i], j] = 0.0;
                    }
                }

                //For the working U matrix, subtract the ratioed active row from the rows below it.
                //Update the columns of the rows below the working row.  k is the row index.
                for (int k = i + 1; k < m_nNumRows; k++)
                {
                    //Store the value of the first element in the working row
                    //of the U matrix.
                    dRowFirstElementValue = mUWorking[nP[k], i];
                    //Go accross the columns of row k.
                    for (int j = 0; j < m_nNumRows; j++)
                    {
                        if (j < i)
                        {
                            //If j<1, then the U matrix element value is 0.
                            mUWorking[nP[k], j] = 0.0;
                        }
                        else if (j == i)
                        {
                            //If i == j, the L matrix value is the value of the
                            //element in the working U matrix.
                            mLWorking[nP[k], j] = dRowFirstElementValue;
                            //The element value of the L matrix for j>i is 0
                            mUWorking[nP[k], j] = 0.0;
                        }
                        else //j>i
                        {
                            mUWorking[nP[k], j] = mUWorking[nP[k], j] - dRowFirstElementValue * mUWorking[nP[i], j];
                        }
                    }
                }
            }

            for (int i = 0; i < m_nNumRows; i++)
            {
                for (int j = 0; j < m_nNumRows; j++)
                {
                    mU[i, j] = mUWorking[nP[i], j];
                    mL[i, j] = mLWorking[nP[i], j];
                }
            }

            resRet.U = mU;
            resRet.L = mL;
            resRet.PivotArray = nP;

            return resRet;
        }

        public GeneralMatrix Invert()
        {
            Debug.Assert(m_nNumRows == m_nNumColumns);
            return SolveFor(Identity(m_nNumRows));
        }

    }

    public class LUDecompositionResults
    {
        private GeneralMatrix m_matL;
        private GeneralMatrix m_matU;
        private int[] m_nPivotArray;
        private LUDecompositionResultStatus m_enuStatus = LUDecompositionResultStatus.OK;

        public LUDecompositionResults()
        {
        }

        public LUDecompositionResults(GeneralMatrix matL, GeneralMatrix matU, int[] nPivotArray, LUDecompositionResultStatus enuStatus)
        {
            m_matL = matL;
            m_matU = matU;
            m_nPivotArray = nPivotArray;
            m_enuStatus = enuStatus;
        }

        public GeneralMatrix L
        {
            get { return m_matL; }
            set { m_matL = value; }
        }

        public GeneralMatrix U
        {
            get { return m_matU; }
            set { m_matU = value; }
        }

        public int[] PivotArray
        {
            get { return m_nPivotArray; }
            set { m_nPivotArray = value; }
        }

        public LUDecompositionResultStatus Status
        {
            get { return m_enuStatus; }
            set { m_enuStatus = value; }
        }
    }

    public enum LUDecompositionResultStatus
    {
        OK = 0,
        LinearlyDependent = 1
    }
}