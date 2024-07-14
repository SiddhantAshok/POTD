using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFeatures.InterviewCodingQuestions.LeetCodeDaily
{
    internal class MaximumScoreForSubstringRemove
    {

        internal static int maximumGain(string s, int x, int y)
        {
            int score = 0;
            Stack<char> stackcharacter = new Stack<char>();
            if (x > y)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (stackcharacter.Count > 0)
                    {
                        stackcharacter.Peek();
                    }
                    else
                    {
                        stackcharacter.Push(s[i]);
                    }
                }
            }
            else
            {

            }


            //Below solution is not optimized time limit exceeded
            //while (s.Contains("ab") || s.Contains("ba"))
            //{
            //    if (x > y)
            //    {
            //        if (s.Contains("ab"))
            //        {
            //            int pos = s.IndexOf("ab");
            //            if (pos > -1)
            //                s = s.Substring(0, pos) + "" + s.Substring(pos + 2);
            //            score += x;
            //        }
            //        else if(s.Contains("ba"))
            //        {
            //            int pos = s.IndexOf("ba");
            //            if (pos > -1)
            //                s = s.Substring(0, pos) + "" + s.Substring(pos + 2);
            //            score += y;
            //        }
            //    }
            //    else
            //    {
            //        if (s.Contains("ba"))
            //        {
            //            int pos = s.IndexOf("ba");
            //            if (pos > -1)
            //                s = s.Substring(0, pos) + "" + s.Substring(pos + 2);
            //            score += y;
            //        }else if (s.Contains("ab"))
            //        {
            //            int pos = s.IndexOf("ab");
            //            if (pos > -1)
            //                s = s.Substring(0, pos) + "" + s.Substring(pos + 2);
            //            score += x;
            //        }
            //    }
            //}
            return score;
        }

        public static int MaximumGain(string s, int x, int y)
        {
            int totalScore = 0;

            // Helper function to remove a specific substring and calculate the score
            string RemoveSubstring(string str, string sub, int points, out int score)
            {
                Stack<char> stack = new Stack<char>();
                score = 0;

                foreach (char c in str)
                {
                    if (stack.Count > 0 && stack.Peek() == sub[0] && c == sub[1])
                    {
                        stack.Pop();
                        score += points;
                    }
                    else
                    {
                        stack.Push(c);
                    }
                }

                // Reconstruct the remaining string after removal
                char[] remainingChars = stack.ToArray();
                Array.Reverse(remainingChars);
                return new string(remainingChars);
            }

            // Determine the order of operations
            if (x >= y)
            {
                // Remove "ab" first, then "ba"
                s = RemoveSubstring(s, "ab", x, out int score1);
                totalScore += score1;
                s = RemoveSubstring(s, "ba", y, out int score2);
                totalScore += score2;
            }
            else
            {
                // Remove "ba" first, then "ab"
                s = RemoveSubstring(s, "ba", y, out int score1);
                totalScore += score1;
                s = RemoveSubstring(s, "ab", x, out int score2);
                totalScore += score2;
            }

            return totalScore;
        }

    }
}
