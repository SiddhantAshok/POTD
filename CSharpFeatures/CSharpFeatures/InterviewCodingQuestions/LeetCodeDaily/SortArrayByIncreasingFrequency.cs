using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpFeatures.InterviewCodingQuestions.LeetCodeDaily
{
    internal class SortArrayByIncreasingFrequency
    {
        public static int[] FrequencySort(int[] nums)
        {
            //Dictionary<int, int> sort = new Dictionary<int, int>();
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (sort.ContainsKey(nums[i]))
            //    {
            //        sort[nums[i]]++;
            //    }
            //    else
            //    {
            //        sort[nums[i]] = 1;
            //    }

            //}


            // Group the numbers by their values and count the frequency
            var frequencyDict = nums.GroupBy(n => n)
                                    .ToDictionary(g => g.Key, g => g.Count());

            // Sort the array based on the frequency and then by value in decreasing order
            var sortedNums = nums.OrderBy(n => frequencyDict[n])
                                 .ThenByDescending(n => n)
                                 .ToArray();

            return sortedNums;
        }
    }
}
