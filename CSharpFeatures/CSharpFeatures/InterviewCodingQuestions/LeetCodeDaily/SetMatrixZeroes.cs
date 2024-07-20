using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFeatures.InterviewCodingQuestions.LeetCodeDaily
{
    internal class SetMatrixZeroes
    {
        public static void SetZeroes(int[][] matrix)
        {

            List<(int, int)> keyValuePairs = new List<(int, int)>();
            int numberOfRows = matrix.Length;
            for (int x = 0; x < numberOfRows; x++)
            {
                int numberOfColumns = matrix[x].Length;
                for (int y = 0; y < numberOfColumns; y++)
                {
                    if (matrix[x][y] == 0)
                    {
                        keyValuePairs.Add((x, y));
                        //for (int i = 0; i < numberOfRows; i++)
                        //{
                        //    matrix[i][y] = 0;
                        //}

                        //for (int j = 0; j < numberOfColumns; j++)
                        //{
                        //    matrix[x][j] = 0;
                        //}



                    }
                }
            }

            foreach (var pair in keyValuePairs)
            {
                for (int i = 0; i < matrix.Length; i++)
                {
                    matrix[i][pair.Item2] = 0;
                }

                for (int j = 0; j < matrix[0].Length; j++)
                {
                    matrix[pair.Item1][j] = 0;
                }
            }

            foreach (var item in matrix)
            {
                foreach (var pair in item) {
                    Console.Write(pair);
                }
                Console.WriteLine();
            }
        }
    }
}
