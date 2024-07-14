using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpFeatures.CollectionsManupulation
{
    public class ListManupulation
    {

        public static int? secondHighestNumber(List<int> numbers)
        {
            #region Basic Logic
            int secondHighest = 0;
            if (numbers.Count > 2)
            {
                int highestNumber = 0;

                for (int i = 0; i < numbers.Count; i++)
                {
                    if (highestNumber < numbers[i])
                    {
                        secondHighest = highestNumber;
                        highestNumber = numbers[i];
                    }
                }
            }
            return secondHighest;
            #endregion


            #region Using LINQ
            //// Remove duplicates and sort in descending order
            //List<int> distinctSortedNumbers = numbers.Distinct().OrderByDescending(n => n).ToList();

            //// Check if there are at least two unique numbers
            //if (distinctSortedNumbers.Count >= 2)
            //{
            //    return distinctSortedNumbers[1];
            //}

            //// Return null if there is no second highest number
            //return null;
            #endregion
        }
    }
}
