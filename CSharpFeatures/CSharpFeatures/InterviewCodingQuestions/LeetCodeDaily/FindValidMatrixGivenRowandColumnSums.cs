using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFeatures.InterviewCodingQuestions.LeetCodeDaily
{
    internal class FindValidMatrixGivenRowandColumnSums
    {

        public static int[][] RestoreMatrix(int[] rowSum, int[] colSum)
        {
            //int[][] matrix = new int[rowSum.Length][];
            //int rowlength = rowSum.Length;
            //for (int i = 0; i < rowlength; i++)
            //{
            //    int collength = colSum.Length;
            //    for (int j = 0; j < collength; j++)
            //    {
            //        if (i == 0)
            //        {
            //            matrix[i][j] = rowSum[i];
            //            rowSum[i] = rowSum[i];
            //        }
            //    }
            //}

            //return matrix;


            int rows = rowSum.Length;
            int cols = colSum.Length;
            int[][] matrix = new int[rows][];
            for (int i = 0; i < rows; i++)
            {
                matrix[i] = new int[cols];
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    int value = Math.Min(rowSum[i], colSum[j]);
                    matrix[i][j] = value;
                    rowSum[i] -= value;
                    colSum[j] -= value;
                }
            }

            return matrix;
        }
    }
}
