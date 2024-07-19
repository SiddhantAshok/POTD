using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFeatures.InterviewCodingQuestions.LeetCodeDaily
{

    //Question : You are given a string s that consists of lower case English letters and brackets.

    //Reverse the strings in each pair of matching parentheses, starting from the innermost one.

    //Your result should not contain any brackets.


    //Example 1:

    //Input: s = "(abcd)"
    //Output: "dcba"
    //Example 2:

    //Input: s = "(u(love)i)"
    //Output: "iloveu"
    //Explanation: The substring "love" is reversed first, then the whole string is reversed.
    //Example 3:

    //Input: s = "(ed(et(oc))el)"
    //Output: "leetcode"
    //Explanation: First, we reverse the substring "oc", then "etco", and finally, the whole string.

    public class ReverseStringBetweenParenthesis
    {
        //public static string ReverseParentheses(string s)
        //{
        //    Stack<char> stringStack = new Stack<char>();
        //    string finalString = string.Empty;
        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        if (s[i].Equals('('))
        //        {
        //            stringStack.Push(s[i]);
        //        }
        //        else if (!s[i].Equals(')'))
        //        {
        //            stringStack.Push(s[i]);
        //        }
        //        else
        //        {
        //            int length = stringStack.Count;
        //            //finalString = ReverseString(finalString);
        //            string subString = string.Empty;
        //            for (int j = 0; j < length; j++)
        //            {
        //                if (stringStack.Peek().Equals('('))
        //                {
        //                    stringStack.Pop();
        //                    //stringStack.Push(finalString);
        //                    for (int x = 0; x < subString.Length; x++)
        //                    {
        //                        stringStack.Push(subString[x]);
        //                    }

        //                    break;
        //                }
        //                subString += stringStack.Pop();

        //            }
        //            //finalString += subString;
        //            //finalString = ReverseString(finalString);
        //        }
        //    }
        //    int stacklength = stringStack.Count;
        //    for (int i = 0; i < stacklength; i++)
        //    {
        //        finalString +=  stringStack.Pop();
        //    }
        //    return ReverseString(finalString);
        //}

        //public static string ReverseString(string s)
        //{
        //    char[] charArray = new char[s.Length];
        //    int index = 0;
        //    for (int i = s.Length - 1; i >= 0; i--)
        //    {
        //        charArray[index++] = s[i];
        //    }
        //    return new string(charArray);
        //}

        public static string ReverseParentheses(string s)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in s)
            {
                if (c == ')')
                {
                    // Pop characters until we find an opening parenthesis '('
                    StringBuilder sb = new StringBuilder();
                    while (stack.Count > 0 && stack.Peek() != '(')
                    {
                        sb.Append(stack.Pop());
                    }
                    // Pop the opening parenthesis '('
                    if (stack.Count > 0 && stack.Peek() == '(')
                    {
                        stack.Pop();
                    }
                    // Push the reversed substring back to the stack
                    foreach (char ch in sb.ToString())
                    {
                        stack.Push(ch);
                    }
                }
                else
                {
                    stack.Push(c);
                }
            }

            // Build the final result string from the stack
            StringBuilder result = new StringBuilder();
            while (stack.Count > 0)
            {
                result.Insert(0, stack.Pop());
            }

            return result.ToString();
        }

    }
}
