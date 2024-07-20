using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFeatures.InterviewCodingQuestions.LeetCodeDaily
{
    class LuckyNumbersinaMatrix
    {
        public static IList<int> LuckyNumbers(int[][] matrix)
        {
            

            List<int> luckyNumbers = new List<int>();
            int rowCount = matrix.Length;
            for (int i = 0; i < rowCount; i++)
            {
                int colCount = matrix[i].Length;
                for (int j = 0; j < colCount; j++)
                {
                    var currentNumber = matrix[i][j];
                    bool isLucky = true;
                    for (int x = 0; x < rowCount; x++)
                    {
                        if (currentNumber < matrix[x][j])
                        {
                            isLucky = false;
                            break;
                        }
                    }

                    if (isLucky)
                    {
                        for (int y = 0; y < colCount; y++)
                        {
                            if (currentNumber > matrix[i][y])
                            {
                                isLucky = false;
                                break;
                            }
                        }
                    }

                    if (isLucky)
                    {
                        luckyNumbers.Add(currentNumber);
                    }
                }

            }

            return luckyNumbers;
        }


        public static IList<int> LuckyNumbersByGPT(int[][] matrix)
        {
            List<int> luckyNumbers = new List<int>();

            int rowCount = matrix.Length;
            int colCount = matrix[0].Length;

            // Step 1: Find the minimum element in each row
            int[] rowMins = new int[rowCount];
            int[] minColIndices = new int[rowCount];
            for (int i = 0; i < rowCount; i++)
            {
                rowMins[i] = matrix[i][0];
                minColIndices[i] = 0;
                for (int j = 1; j < colCount; j++)
                {
                    if (matrix[i][j] < rowMins[i])
                    {
                        rowMins[i] = matrix[i][j];
                        minColIndices[i] = j;
                    }
                }
            }

            // Step 2: Check if the row minimums are the maximum in their respective columns
            for (int i = 0; i < rowCount; i++)
            {
                int min = rowMins[i];
                int colIndex = minColIndices[i];
                bool isLucky = true;
                for (int x = 0; x < rowCount; x++)
                {
                    if (matrix[x][colIndex] > min)
                    {
                        isLucky = false;
                        break;
                    }
                }

                if (isLucky)
                {
                    luckyNumbers.Add(min);
                }
            }

            return luckyNumbers;
        }

    }
}
