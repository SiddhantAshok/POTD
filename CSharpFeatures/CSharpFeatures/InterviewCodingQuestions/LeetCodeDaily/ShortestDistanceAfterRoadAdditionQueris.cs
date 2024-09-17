using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFeatures.InterviewCodingQuestions.LeetCodeDaily
{
    internal class ShortestDistanceAfterRoadAdditionQueris
    {
        public int[] ShortestDistanceAfterQueries(int n, int[][] queries)
        {
            int[] distances = new int[queries.Length];
            int[] nodes = new int[n];
            for (int j = 0; j < n; j++)
            {
                nodes[j] = j;
            }

            for (int i = 0; i < queries.Length; i++)
            {
                int firstNode = queries[i][0];
                int lastNode = queries[i][1];



            }

            return distances;
        }
    }
}
