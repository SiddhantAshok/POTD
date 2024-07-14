using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFeatures.InterviewCodingQuestions.LeetCodeDaily
{
    internal class LexicographicallySmallestString
    {
        public static string GetSmallestString(string s)
        {
            StringBuilder smallestString = new StringBuilder();
            int lastDigit = 0;
            bool flag = false;
            for (int i = 0; i < s.Length; i++)
            {
                int digit1 = Convert.ToInt16(s[i].ToString());

                if (i > 0 && !flag && ((digit1 % 2 == 0 && lastDigit % 2 == 0) || (digit1 % 2 != 0 && lastDigit % 2 != 0)) && lastDigit > digit1)
                {
                    //if ((digit1 % 2 == 0 && lastDigit % 2 == 0) || (digit1 % 2 != 0 && lastDigit % 2 != 0))
                    //{
                        //if (lastDigit > digit1)
                        {
                            smallestString.Length--;
                            smallestString.Append(digit1);
                            smallestString.Append(lastDigit);
                            flag = true;
                        }
                        //else
                        //{

                        //    smallestString.Append(digit1);
                        //}
                    //}
                    //else
                    //{
                    //    smallestString.Append(digit1);
                    //}

                }
                else
                {
                    smallestString.Append(digit1);
                }
                lastDigit = digit1;
            }
            return smallestString.ToString();
        }


        public static string GetLargestString(string s)
        {

            StringBuilder smallestString = new StringBuilder();
            int lastDigit = 0;
            bool flag = false;
            for (int i = 0; i < s.Length; i++)
            {
                int digit1 = Convert.ToInt16(s[i].ToString());

                if (i > 0 && !flag)
                {
                    if ((digit1 % 2 == 0 && lastDigit % 2 == 0) || (digit1 % 2 != 0 && lastDigit % 2 != 0))
                    {
                        if (lastDigit > digit1)
                        {
                            smallestString.Length--;
                            smallestString.Append(digit1);
                            smallestString.Append(lastDigit);
                            flag = true;
                        }
                        else
                        {

                            smallestString.Append(digit1);
                        }
                    }
                    else
                    {
                        smallestString.Append(digit1);
                    }

                }
                else
                {
                    smallestString.Append(digit1);
                }
                lastDigit = digit1;
            }
            return smallestString.ToString();
        }
    }
}
