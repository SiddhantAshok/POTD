using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpFeatures.InterviewCodingQuestions.LeetCodeDaily
{
    internal class SortthePeople
    {

        public static string[] SortPeople(string[] names, int[] heights)
        {
            for (int i = 0; i < names.Length; i++)
            {
                int highestIndex = 0;
                int highestHeight = 0;
                for (int j = i; j < heights.Length; j++)
                {
                    //if (heights[j] > heights[j + 1])
                    if (highestHeight < heights[j])
                    {
                        highestHeight = heights[j];
                        highestIndex = j;
                    }

                }

                if (i != highestIndex)
                {


                    var name = names[i];
                    names[i] = names[highestIndex];
                    names[highestIndex] = name;

                    var height = heights[i];
                    heights[i] = heights[highestIndex];
                    heights[highestIndex] = height;
                }

            }


            return names;
        }


        public static string[] SortedPeople(string[] names, int[] heights)
        {
            // Create a list of tuples containing names and heights
            List<(string name, int height)> people = new List<(string, int)>();
            for (int i = 0; i < names.Length; i++)
            {
                people.Add((names[i], heights[i]));
            }

            // Sort the list by height in descending order
            people.Sort((x, y) => y.height.CompareTo(x.height));

            // Extract the sorted names
            string[] sortedNames = people.Select(person => person.name).ToArray();

            return sortedNames;
        }

        public static string[] SortingPeople(string[] names, int[] heights)
        {
            // Create an array of indices from 0 to n-1
            int n = names.Length;
            int[] indices = Enumerable.Range(0, n).ToArray();

            // Sort the indices array based on the heights in descending order
            Array.Sort(indices, (i, j) => heights[j].CompareTo(heights[i]));

            // Create the result array using the sorted indices
            string[] sortedNames = new string[n];
            for (int i = 0; i < n; i++)
            {
                sortedNames[i] = names[indices[i]];
            }

            return sortedNames;
        }
    }
}
