using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFeatures.InterviewCodingQuestions.LeetCodeDaily
{
    public class neighborSum
    {

        int[][] NeighborSumGrid;
        public neighborSum(int[][] grid)
        {
            this.NeighborSumGrid = grid;
        }

        public int AdjacentSum(int value)
        {
            int adjacentSum = 0;
            int rowLength = NeighborSumGrid.Length;
            bool isSumCalculated = false;
            for (int row = 0; row < rowLength; row++)
            {
                if (isSumCalculated)
                {
                    break;
                }
                int columnLength = NeighborSumGrid[row].Length;
                for (int col = 0; col < columnLength; col++)
                {
                    if (NeighborSumGrid[row][col] == value)
                    {
                        if (col > 0)
                        {
                            adjacentSum += NeighborSumGrid[row][col - 1];
                        }

                        if (col < columnLength - 1)
                        {
                            adjacentSum += NeighborSumGrid[row][col + 1];
                        }

                        if (row > 0)
                        {
                            adjacentSum += NeighborSumGrid[row - 1][col];
                        }

                        if (row < rowLength - 1)
                        {
                            adjacentSum += NeighborSumGrid[row + 1][col];
                        }
                        isSumCalculated = true;
                        break;
                    }
                }
            }

            return adjacentSum;
        }

        public int DiagonalSum(int value)
        {
            int diagonalSum = 0;
            int rowLength = NeighborSumGrid.Length;
            bool isSumCalculated = false;
            for (int row = 0; row < rowLength; row++)
            {
                if (isSumCalculated)
                {
                    break;
                }
                int columnLength = NeighborSumGrid[row].Length;
                for (int col = 0; col < columnLength; col++)
                {
                    if (NeighborSumGrid[row][col] == value)
                    {
                        if (col > 0)
                        {
                            if (row > 0)
                            {

                                diagonalSum += NeighborSumGrid[row - 1][col - 1];
                                if (row < rowLength - 1)
                                {
                                    diagonalSum += NeighborSumGrid[row + 1][col - 1];
                                }
                            }
                            else if (row < rowLength - 1)
                            {
                                diagonalSum += NeighborSumGrid[row + 1][col - 1];
                            }
                        }

                        if (col < columnLength - 1)
                        {
                            if (row < rowLength - 1)
                            {

                                diagonalSum += NeighborSumGrid[row + 1][col + 1];
                                if (row > 0)
                                {
                                    diagonalSum += NeighborSumGrid[row - 1][col + 1];
                                }
                            }
                            else if (row > 0)
                            {
                                diagonalSum += NeighborSumGrid[row - 1][col + 1];
                            }
                        }

                        //if ()
                        //{
                        //    diagonalSum += NeighborSumGrid[row - 1][col];
                        //}

                        //if (row < rowLength)
                        //{
                        //    diagonalSum += NeighborSumGrid[row + 1][col];
                        //}
                        isSumCalculated = true;
                        break;
                    }
                }
            }

            return diagonalSum;
        }
    }
}
