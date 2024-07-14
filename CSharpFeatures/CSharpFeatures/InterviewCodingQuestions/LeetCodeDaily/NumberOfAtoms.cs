using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFeatures.InterviewCodingQuestions.LeetCodeDaily
{
    internal class NumberOfAtoms
    {
        //public string CountOfAtoms1(string formula)
        //{

        //    Dictionary<string, int> atoms = new Dictionary<string, int>();
        //    for (int i = 0; i < formula.Length; i++)
        //    {
        //        //if (int.TryParse(formula[i].ToString(), out int result))
        //        //{

        //        //}
        //        //else
        //        //{
        //        //    if (atoms.ContainsKey(formula[i]))
        //        //    {
        //        //        atoms.Add(formula[i], formula[i+1]);
        //        //    }

        //        //}


        //        if (formula[i] == '(')
        //        {
        //            int j = i + 1;
        //            while (formula[j] != ')')
        //            {
        //                string atomName = string.Empty;
        //                if (char.IsUpper(formula[j]))
        //                {
        //                    if (char.IsLower(formula[j + 1]))
        //                    {
        //                        atomName = formula[j].ToString() + formula[j + 1].ToString();
        //                        if (atoms.ContainsKey(atomName))
        //                        {
        //                            atoms.Add(atomName, char.IsNumber(formula[j + 2]) ?  atoms[atomName] + formula[j + 2] : 1);
        //                        }
        //                        else
        //                        {
        //                            atoms.Add(atomName, char.IsNumber(formula[j + 2]) ? formula[j + 2] : 1);

        //                        }

        //                    }
        //                }
        //                else if (char.IsNumber(formula[j]))
        //                {

        //                }
        //                j++;
        //            }

        //            i = j;
        //        }
        //    }
        //    return string.Empty;
        //}


        public static string CountOfAtoms(string formula)
        {
            var stack = new Stack<Dictionary<string, int>>();
            stack.Push(new Dictionary<string, int>());

            int i = 0;
            int n = formula.Length;

            while (i < n)
            {
                if (formula[i] == '(')
                {
                    stack.Push(new Dictionary<string, int>());
                    i++;
                }
                else if (formula[i] == ')')
                {
                    i++;
                    int start = i;
                    while (i < n && char.IsDigit(formula[i])) i++;
                    int multiplier = i > start ? int.Parse(formula.Substring(start, i - start)) : 1;

                    var top = stack.Pop();
                    var peek = stack.Peek();

                    foreach (var kv in top)
                    {
                        if (!peek.ContainsKey(kv.Key))
                        {
                            peek[kv.Key] = 0;
                        }
                        peek[kv.Key] += kv.Value * multiplier;
                    }
                }
                else
                {
                    int start = i;
                    i++;
                    while (i < n && char.IsLower(formula[i])) i++;
                    string name = formula.Substring(start, i - start);

                    start = i;
                    while (i < n && char.IsDigit(formula[i])) i++;
                    int count = i > start ? int.Parse(formula.Substring(start, i - start)) : 1;

                    var peek = stack.Peek();
                    if (!peek.ContainsKey(name))
                    {
                        peek[name] = 0;
                    }
                    peek[name] += count;
                }
            }

            var finalCount = stack.Pop();
            var sortedNames = new List<string>(finalCount.Keys);
            sortedNames.Sort();

            var result = new StringBuilder();
            foreach (var name in sortedNames)
            {
                result.Append(name);
                if (finalCount[name] > 1)
                {
                    result.Append(finalCount[name]);
                }
            }

            return result.ToString();
        }
    }
}
