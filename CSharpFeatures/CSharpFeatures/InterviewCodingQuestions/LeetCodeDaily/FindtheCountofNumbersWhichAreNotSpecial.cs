using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFeatures.InterviewCodingQuestions.LeetCodeDaily
{
    internal class FindtheCountofNumbersWhichAreNotSpecial
    {
        public static int NonSpecialCount(int l, int r)
        {
            List<int> notSpecialNumbers = new List<int>();
            for (int i = l; i <= r; i = i + 1)
            {
                int divisorCount = 0;
                if (i == 1 || i == 2 || i == 3)
                {
                    notSpecialNumbers.Add(i);
                    continue;
                }

                for (int j = 1; j <= i; j = j + 1)
                {
                    if (j * 2 <= i)
                    {

                        if (i % j == 0 && i != j || i == 1)
                        {
                            divisorCount++;
                        }

                    }
                    else
                    {
                        if (divisorCount != 2)
                        {
                            divisorCount = divisorCount + (i - j);
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (divisorCount > 2)
                    {
                        notSpecialNumbers.Add(i);
                        break;
                    }
                }

                if (divisorCount == 1)
                {
                    notSpecialNumbers.Add(i);
                    //break;
                }
            }

            return notSpecialNumbers.Count;
        }


        public static int NonSpecialCountSecond(int l, int r)
        {
            int count = 0;

            for (int i = l; i <= r; i++)
            {
                if (IsNonSpecial(i))
                {
                    count++;
                }
            }

            return count;
        }

        private static bool IsNonSpecial(int number)
        {
            if (number == 1)
            {
                return true;
            }

            int divisorCount = 0;
            for (int j = 1; j <= number; j++)
            {
                if (j * j <= number)
                {
                    if (number % j == 0 && number != j)
                    {
                        //if (j == number)
                        //{
                        divisorCount++;
                        //}
                        //else
                        //{
                        //    divisorCount += 2;
                        //}

                    }

                }
                else
                {
                    if (divisorCount != 2)
                        divisorCount = divisorCount + (number - j);

                }
                if (divisorCount > 2)
                {
                    return true;
                }

            }

            //int divisorCount = 0;
            //for (int j = 1; j <= number; j++)
            //{
            //    if (number % j == 0)
            //    {
            //        if (j * j == number)
            //        {
            //            divisorCount++;
            //        }
            //        else
            //        {
            //            divisorCount += 2;
            //        }
            //    }

            //    if (divisorCount > 2)
            //    {
            //        return true;
            //    }
            //}


            return divisorCount == 1;
        }
    }
}
