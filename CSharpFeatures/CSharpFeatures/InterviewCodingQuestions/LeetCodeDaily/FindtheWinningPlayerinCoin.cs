using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFeatures.InterviewCodingQuestions.LeetCodeDaily
{
    internal class FindtheWinningPlayerinCoin
    {
        public static string LosingPlayer(int x, int y)
        {
            int turnsCount = y / 4; //for the coin of 10
            int compare = x > turnsCount ? turnsCount : x;
            if (compare % 2 == 0)
            {
                return "Bob";
            }
            else
            {
                return "Alice";
            }
        }
    }
}
