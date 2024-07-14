using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace CSharpFeatures.InterviewCodingQuestions.LeetCodeDaily
{
    internal class RobotCollisions
    {
        public static IList<int> SurvivedRobotsHealths(int[] positions, int[] healths, string directions)
        {

            bool isContinueMoving(string directions)
            {
                bool checkRightFlag = false;
                bool checkLeftFlag = false;
                //int skipForAlterCheck = 0;
                //foreach (char direction in directions)
                //{


                //if (direction == 'R')
                //{
                //    checkRightFlag = true;
                //    if (checkLeftFlag)
                //    {
                //        skipForAlterCheck++;
                //        if (skipForAlterCheck == 1)
                //        {
                //            checkLeftFlag = false;
                //        }
                //        if (skipForAlterCheck > 1)
                //        {
                //            return true;
                //        }
                //    }
                //}
                //else if (direction == 'L')
                //{
                //    checkLeftFlag = true;
                //    if (checkRightFlag)
                //    {
                //        skipForAlterCheck++;
                //        if (skipForAlterCheck == 1)
                //        {
                //            checkRightFlag = false;
                //        }
                //        if (skipForAlterCheck > 1)
                //        {
                //            return true;
                //        }
                //    }
                //}
                //}

                foreach (char direction in directions)
                {
                    if (direction == 'R')
                    {
                        checkRightFlag = true;
                    }
                    else if (direction == 'L')
                    {
                        checkLeftFlag = true;
                        if (checkRightFlag)
                        {
                            return true;
                        }
                    }
                }


                //if (directions.Contains("RL"))
                //{
                //    return true;
                //}
                return false;
            }

            //Console.WriteLine(isContinueMoving(directions));

            //while (positions.Length < 2 && isContinueMoving(directions))
            while (isContinueMoving(directions))
            {
                for (int i = 0; i < directions.Length; i++)
                {
                    if (directions[i] == 'R')
                    {
                        positions[i] += 1;
                    }
                    else if (directions[i] == 'L')
                    {
                        positions[i] -= 1;
                    }
                }

                int[] newPositions = new int[positions.Length];
                int duplicateOccurenceFirst = -1, duplicateOccurenceSecond = -1;
                for (int j = 0; j < positions.Length; j++)
                {
                    if (newPositions.Contains(positions[j]))
                    {
                        duplicateOccurenceFirst = Array.IndexOf(newPositions, positions[j]);
                        duplicateOccurenceSecond = j;

                        if (healths[duplicateOccurenceFirst] > healths[duplicateOccurenceSecond])
                        {
                            healths[duplicateOccurenceFirst] = healths[duplicateOccurenceFirst] - 1;

                            // Convert array to List
                            List<int> list = new List<int>(healths);

                            // Remove element at the specified index
                            list.RemoveAt(duplicateOccurenceSecond);

                            // Convert List back to array
                            healths = list.ToArray();
                            //duplicateOccurenceSecond = -1;
                            duplicateOccurenceFirst = -1;
                        }
                        else if(healths[duplicateOccurenceFirst] < healths[duplicateOccurenceSecond])
                        {
                            healths[duplicateOccurenceSecond] = healths[duplicateOccurenceSecond] - 1;

                            // Convert array to List
                            List<int> list = new List<int>(healths);

                            // Remove element at the specified index
                            list.RemoveAt(duplicateOccurenceFirst);

                            // Convert List back to array
                            healths = list.ToArray();
                            //duplicateOccurenceFirst = -1;
                            duplicateOccurenceSecond = -1;
                        }
                        else if(healths[duplicateOccurenceFirst] == healths[duplicateOccurenceSecond])
                        {
                            // Convert array to List
                            List<int> list = new List<int>(healths);

                            // Remove element at the specified index
                            list.RemoveAt(duplicateOccurenceSecond);
                            list.RemoveAt(duplicateOccurenceFirst);

                            // Convert List back to array
                            healths = list.ToArray();
                        }

                        break;
                    }
                    else
                    {
                        newPositions[j] = positions[j];
                    }

                }

                if (duplicateOccurenceFirst != -1 && duplicateOccurenceSecond != -1)
                {
                    // Convert array to List
                    List<int> list = new List<int>(positions);

                    // Remove element at the specified index
                    list.RemoveAt(duplicateOccurenceSecond);
                    list.RemoveAt(duplicateOccurenceFirst);

                    // Convert List back to array
                    positions = list.ToArray();

                    directions = directions.Remove(duplicateOccurenceSecond, 1);
                    directions = directions.Remove(duplicateOccurenceFirst, 1);
                }else if    (duplicateOccurenceFirst != -1)
                {
                    // Convert array to List
                    List<int> list = new List<int>(positions);

                    // Remove element at the specified index
                    list.RemoveAt(duplicateOccurenceFirst);

                    // Convert List back to array
                    positions = list.ToArray();
                    directions = directions.Remove(duplicateOccurenceFirst, 1);
                }
                else if (duplicateOccurenceSecond != -1)
                {
                    // Convert array to List
                    List<int> list = new List<int>(positions);

                    // Remove element at the specified index
                    list.RemoveAt(duplicateOccurenceSecond);

                    // Convert List back to array
                    positions = list.ToArray();
                    directions = directions.Remove(duplicateOccurenceSecond, 1);
                }

            }

            return new List<int>(healths);
        }

        //static void RemoveAt(ref int[] array, int index)
        //{
        //    // Convert array to List
        //    List<int> list = new List<int>(array);

        //    // Remove element at the specified index
        //    list.RemoveAt(index);

        //    // Convert List back to array
        //    array = list.ToArray();
        //}

        //Working optimized code
        public static IList<int> GetSurvivingRobots(int[] positions, int[] healths, string directions)
        {
            int n = positions.Length;
            var robots = new List<Robot>();

            // Create a list of robots with their properties
            for (int i = 0; i < n; i++)
            {
                robots.Add(new Robot
                {
                    Index = i,
                    Position = positions[i],
                    Health = healths[i],
                    Direction = directions[i]
                });
            }

            // Sort robots based on their positions
            robots = robots.OrderBy(r => r.Position).ToList();

            Stack<Robot> stack = new Stack<Robot>();

            foreach (var robot in robots)
            {
                while (stack.Count > 0 && stack.Peek().Direction == 'R' && robot.Direction == 'L')
                {
                    var last = stack.Pop();
                    if (last.Health > robot.Health)
                    {
                        last.Health--;
                        stack.Push(last);
                        robot.Health = 0;
                    }
                    else if (last.Health < robot.Health)
                    {
                        robot.Health--;
                        last.Health = 0;
                    }
                    else
                    {
                        last.Health = 0;
                        robot.Health = 0;
                    }

                    if (robot.Health == 0)
                    {
                        break;
                    }
                }

                if (robot.Health > 0)
                {
                    stack.Push(robot);
                }
            }

            // Get the health of the surviving robots in the original order
            return robots.Where(r => r.Health > 0).OrderBy(r => r.Index).Select(r => r.Health).ToArray();
        }

        public class Robot
        {
            public int Index { get; set; }
            public int Position { get; set; }
            public int Health { get; set; }
            public char Direction { get; set; }
        }
    }
}
