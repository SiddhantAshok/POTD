using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFeatures.InterviewCodingQuestions.LeetCodeDaily
{
    internal class MoveZeroes
    {
        public static void MoveZeroesAtEnd(ref int[] nums)
        {
            //int[] arr = new int[nums.Length];
            int lastNonZero = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[lastNonZero++] = nums[i];
                }
               
            }


            for (int i = lastNonZero; i < nums.Length ; i++)
            {
                nums[i] = 0;
            }
            
        }
    }
}
