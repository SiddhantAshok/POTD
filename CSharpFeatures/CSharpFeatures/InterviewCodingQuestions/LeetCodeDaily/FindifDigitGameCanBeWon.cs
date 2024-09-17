using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpFeatures.InterviewCodingQuestions.LeetCodeDaily
{
    internal class FindifDigitGameCanBeWon
    {
        public bool CanAliceWin(int[] nums)
        {
            bool isAliceWin = false;
            int singleDigitSum = 0;
            int doubleDigitSum = 0;
            int OtherSum = 0;

            for (int i = 0; i < nums.Length; i++){
                if (nums[i] / 10 == 0)
                {
                    singleDigitSum += nums[i];
                }
                else if (nums[i] / 10 >= 1 && nums[i] / 10 < 10)
                {
                    doubleDigitSum += nums[i];
                }
                else
                {
                    OtherSum += nums[i];
                }


            }


            if (singleDigitSum > doubleDigitSum)
            {
                OtherSum += doubleDigitSum;

                if (singleDigitSum > OtherSum)
                {
                    isAliceWin = true;
                }
            }else
            {
                OtherSum += singleDigitSum;

                if(doubleDigitSum > OtherSum)
                {
                    isAliceWin = true;
                }
            }



            return isAliceWin;
        }



        public bool CanAliceWinSecond(int[] nums)
        {
            int singleDigitSum = nums.Where(num => num < 10).Sum();
            int doubleDigitSum = nums.Where(num => num >= 10 && num < 100).Sum();
            int totalSum = nums.Sum();

            return singleDigitSum > totalSum - singleDigitSum || doubleDigitSum > totalSum - doubleDigitSum;
        }
    }
}
