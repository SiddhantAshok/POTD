using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFeatures.InterviewCodingQuestions.InQ_QukkoLabs
{
    public class DrawPattern
    {
        //Interview Question By Quokka Labs
        internal static void Draw(int number)
        {
            for (int i = 0; i < number; i++)
            {
                if (i <= number / 2)
                {
                    string s = new string(' ', i);
                    Console.WriteLine(s + "*" + Environment.NewLine);
                }
                else
                {
                    string s = new string(' ', number - i);
                    Console.WriteLine(s + "*" + Environment.NewLine);
                }
            }
        }


        //Interview Question By Quokka Labs
        //private static void TryCatchCheck()
        //{
        //    try
        //    {
        //        Console.WriteLine("Try");
        //        var i = 1 / 0;  //Compiler error : Division by constant 0 [RunTime : DivideByZeroException]
        //        Console.WriteLine("End Try");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Catch");
        //        var j = 1 / 0;  //Compiler error : Division by constant 0 [Runtime : DivideByZeroException]
        //        Console.WriteLine("End Catch");
        //    }
        //    finally
        //    {
        //        Console.WriteLine("Finally");
        //    }
        //}
    }
}
