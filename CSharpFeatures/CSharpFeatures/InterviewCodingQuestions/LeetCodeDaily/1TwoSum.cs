using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFeatures.InterviewCodingQuestions.LeetCodeDaily
{
    //LeetCode 1. TwoSum
    internal class _1TwoSum
    {
        public int[] TwoSum(int[] nums, int target)
        {
            for (int first = 0; first < nums.Length; first++)
            {
                for (int second = first + 1; second < nums.Length; second++)
                {
                    if (nums[first] + nums[second] == target)
                    {
                        return new int[] { first, second };
                    }
                }
               
            }
            return null;
        }
    }
}
