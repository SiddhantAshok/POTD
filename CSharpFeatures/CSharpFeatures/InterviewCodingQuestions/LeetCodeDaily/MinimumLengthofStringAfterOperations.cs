using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFeatures.InterviewCodingQuestions.LeetCodeDaily
{
    internal class MinimumLengthofStringAfterOperations
    {
        public static int MinimumLength(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                char currentChar = s[i];

                for (int l = i - 1; l >= 0; l--)
                {
                    if (i != l && Math.Abs(i - l) > 1)
                    {
                        if (currentChar == s[l])
                        {
                            s = s.Remove(l, 1);
                            break;
                        }
                    }
                }

                for (int r = i + 1; r < s.Length; r++)
                {
                    if (i != r && Math.Abs(i - r) > 1)
                    {

                        if (currentChar == s[r])
                        {
                            s = s.Remove(r, 1);
                            break;
                        }
                    }
                }
            }

            return s.Length;
        }

        public static int MinLength(string s)
        {
            bool canRemove = true;

            while (canRemove)
            {
                canRemove = false;
                int n = s.Length;
                HashSet<int> indicesToRemove = new HashSet<int>();

                for (int i = 1; i < n - 1; i++)
                {
                    if (s[i] == s[i - 1] || s[i] == s[i + 1])
                    {
                        int left = i - 1;
                        int right = i + 1;

                        while (left >= 0 && s[left] != s[i])
                        {
                            left--;
                        }

                        while (right < n && s[right] != s[i])
                        {
                            right++;
                        }

                        if (left >= 0 && right < n)
                        {
                            indicesToRemove.Add(left);
                            indicesToRemove.Add(right);
                            canRemove = true;
                            break;
                        }
                    }
                }

                if (canRemove)
                {
                    List<char> newString = new List<char>();
                    for (int i = 0; i < n; i++)
                    {
                        if (!indicesToRemove.Contains(i))
                        {
                            newString.Add(s[i]);
                        }
                    }
                    s = new string(newString.ToArray());
                }
            }

            return s.Length;
        }

        public static int MiniLength(string s)
        {

            int n = s.Length;
            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < n; i++)
            {
                if (stack.Count > 0 && stack.Peek() == s[i])
                {
                    // Remove the closest character to the left that is equal to s[i]
                    stack.Pop();
                }
                else
                {
                    stack.Push(s[i]);
                }
            }

            return stack.Count;
        }
    }
}
