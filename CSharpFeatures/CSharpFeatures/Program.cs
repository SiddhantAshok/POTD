using CSharpFeatures.CollectionsManupulation;
using CSharpFeatures.Features.CallingBehaviours;
using CSharpFeatures.ImmutableClasses;
using CSharpFeatures.InterviewCodingQuestions.InQ_QukkoLabs;
using CSharpFeatures.InterviewCodingQuestions.LeetCodeDaily;
using CSharpFeatures.StaticAndInstanceConstructorInAClass;
using System;
using System.Collections.Generic;

namespace CSharpFeatures
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Class can have both Static and instance constructors
            //// Accessing a static member, which triggers the static constructor
            //Console.WriteLine("Creating first instance of MyClass...");
            //StaticAndInstanceTogetherClass obj1 = new StaticAndInstanceTogetherClass(100);
            //obj1.DisplayFields();

            //// Creating another instance, static constructor will not be called again
            //Console.WriteLine("Creating second instance of MyClass...");
            //StaticAndInstanceTogetherClass obj2 = new StaticAndInstanceTogetherClass(200);
            //obj2.DisplayFields();
            #endregion

            #region Understanding Immutable Classes
            //// Creating an immutable instance
            //Person person = new Person("John", "Doe", 30);
            //Console.WriteLine($"Name: {person.FirstName} {person.LastName}, Age: {person.Age}");

            //// Trying to modify the age using the WithAge method
            //Person olderPerson = person.WithAge(35);
            //Console.WriteLine($"Name: {olderPerson.FirstName} {olderPerson.LastName}, Age: {olderPerson.Age}");

            //// Original person object remains unchanged
            //Console.WriteLine($"Original Name: {person.FirstName} {person.LastName}, Age: {person.Age}");
            #endregion

            #region
            //List<int> numbers = new List<int> { 67, 13, 54, 0, 0, 1, 2, 5, 19, 78 };
            //var secondHighestNumberFromList = ListManupulation.secondHighestNumber(numbers);
            //Console.WriteLine(secondHighestNumberFromList);
            #endregion


            #region Find the Maximum Gain Score for removing the Substring
            //int score = MaximumScoreForSubstringRemove.MaximumGain("aabbaaxybbaabb", 5, 4);
            //Console.WriteLine(score);
            #endregion


            #region Robot Collisions
            //int[] positions = new int[] { 1, 2, 5, 6 };
            //int[] healths = new int[] { 10, 10, 11, 11 };
            //var healthList = RobotCollisions.GetSurvivingRobots(positions, healths, "RLRL");
            //foreach (var health in healthList)
            //{
            //    Console.WriteLine(health);
            //}


            #endregion


            #region Lexicographically Smallest String
            //string smallestString = LexicographicallySmallestString.GetSmallestString("45320");
            //Console.WriteLine(smallestString);
            #endregion

            #region Number of Atoms
            //string counts = NumberOfAtoms.CountOfAtoms("Mg(OH)2");
            //Console.WriteLine(counts);

            //Dictionary<string, int> map = new Dictionary<string, int>();

            //map["hello"] = 0;
            //map["hello"] = 1;
            //foreach (var item in map)
            //{
            //    Console.WriteLine(item.Key + item.Value);
            //}
            #endregion


            #region Call for AWT
            //int[][] customers = new int[6][];
            ////customers[0] = new int[] { 1, 2 }; // First customer's waiting times
            ////customers[1] = new int[] { 2, 5 };    // Second customer's waiting times
            ////customers[2] = new int[] { 4, 3 };  //[[5,2],[5,4],[10,3],[20,1]]

            ////[[2,3],[6,3],[7,5],[11,3],[15,2],[18,1]]

            //customers[0] = new int[] { 2, 3 };
            //customers[1] = new int[] { 6, 3 };
            //customers[2] = new int[] { 7, 5 };
            //customers[3] = new int[] { 11, 3 };
            //customers[4] = new int[] { 15, 2 };
            //customers[5] = new int[] { 18, 1 };
            //Console.WriteLine(AWT.AverageWaitingTime(customers));
            #endregion

            #region Reverse the substring between Parentheses
            //var reverseString = ReverseStringBetweenParenthesis.ReverseParentheses("(ed(et(oc))el)");

            //Console.WriteLine(reverseString);
            #endregion

            #region Create Binary tree based on Description 2D Array

            //int[][] array = new int[][]
            //    {
            //        new int[] { 20, 15, 1 },
            //        new int[] { 20, 17, 0 },
            //        new int[] { 50, 20, 1 },
            //        new int[] { 50, 80, 0 },
            //        new int[] { 80, 19, 1 }
            //    };

            //int[][] array = new int[][]
            //{
            //    new int[] { 85, 82, 1 },
            //    new int[] { 74, 85, 1 },
            //    new int[] { 39, 70, 0 },
            //    new int[] { 82, 38, 1 },
            //    new int[] { 74, 39, 0 },
            //    new int[] { 39, 13, 1 }
            //};


            //CreateBinaryTree create = new CreateBinaryTree();
            //create.CreateBinaryTreeByDescription(array);
            #endregion

            #region Binary Tree Traversal

            //TreeNode treeNode = new TreeNode
            //{
            //    val = 50,
            //    left = new TreeNode
            //    {
            //        val = 10,
            //        left = new TreeNode
            //        {
            //            val = 5,
            //            left = null,
            //            right = null
            //        },
            //        right = new TreeNode
            //        {
            //            val = 15,
            //            left = null,
            //            right = null
            //        },
            //    },
            //    right = new TreeNode
            //    {
            //        val = 90,
            //        left = new TreeNode
            //        {
            //            val = 70,
            //            left = null,
            //            right = null
            //        },
            //        right = new TreeNode
            //        {
            //            val = 95,
            //            left = null,
            //            right = new TreeNode
            //            {
            //                val = 97,
            //                left = null,
            //                right = null
            //            },
            //        }
            //    }
            //};

            //BinaryTreeTraversal tree = new BinaryTreeTraversal();
            //var nodeValues = tree.InorderTraversal(treeNode);

            //foreach (var item in nodeValues)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Return Lucky Numbers
            //[[3,7,8],[9,11,13],[15,16,17]]

            //int[][] array = new int[][]
            //{
            //    new int[] { 3,7,8 },
            //    new int[] { 9,11,13 },
            //    new int[] { 15,16,17 }
            //};

            //var luckyNumbers = LuckyNumbersinaMatrix.LuckyNumbersByGPT(array);

            //foreach (var item in luckyNumbers)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Set Matrix Zeros
            //int[][] matrix = new int[][]
            //{
            //    new int[] { 1, 1, 1 },
            //    new int[] { 1, 0, 1 },
            //    new int[] { 1, 1, 1 }
            //};

            //SetMatrixZeroes.SetZeroes(matrix);
            #endregion

            #region Find the matrix on the given row sum and column sum arrays

            //int[] rowSum = new int[] { 3, 8 };
            //int[] colSum = new int[] { 4, 7 };
            //FindValidMatrixGivenRowandColumnSums.RestoreMatrix(rowSum, colSum);
            #endregion

            #region Find the winning Player
            //Console.WriteLine(FindtheWinningPlayerinCoin.LosingPlayer(2, 7));

            #endregion

            #region Minimum Length of String After Operation
            //Console.WriteLine(MinimumLengthofStringAfterOperations.MinimumLength("abaacbcbb"));
            //Console.WriteLine(MinimumLengthofStringAfterOperations.MinimumLength("htukrysju"));
            //Console.WriteLine(MinimumLengthofStringAfterOperations.MinimumLength("aa"));
            #endregion

            #region Number of Bit Changes to Make Two Integers Equal
            //Console.WriteLine(NumberofBitChangestoMakeTwoIntegersEqual.MinChanges(13, 4));
            #endregion


            #region Sort the people
            //var sortedPeople = SortthePeople.SortPeople(new[] { "Mary", "John", "Emma" }, new[] { 180, 165, 170 });

            //foreach (var person in sortedPeople)
            //{
            //    Console.WriteLine(person);
            //}
            #endregion


            #region Move Zeros at the end
            //int[] rowSum = new int[] { 3, 8, 0, 1, 0, 2, 0, 3 };
            //MoveZeroes.MoveZeroesAtEnd(ref rowSum);
            //foreach (int row in rowSum)
            //{
            //    Console.WriteLine(row);
            //}
            #endregion


            #region Find the Number of Not Special Numbers
            //int count = FindtheCountofNumbersWhichAreNotSpecial.NonSpecialCount(1, 3);

            //Console.WriteLine(count);
            #endregion

            #region Design Neighbor Sum Service
            ////int[][] grid = new int[][]
            ////{
            ////    new int[] { 0,1,2 },
            ////    new int[] { 3,4,5 },
            ////    new int[] { 6,7,8 }
            ////};

            //int[][] grid = new int[][]
            //{
            //    new int[] { 3,6,0 },
            //    new int[] { 8,5,1 },
            //    new int[] { 2,4,7 }
            //};

            //neighborSum obj = new neighborSum(grid);
            ////int param_1 = obj.AdjacentSum(1);
            ////int param_12 = obj.AdjacentSum(8);
            //int param_2 = obj.DiagonalSum(2);
            //int param_22 = obj.DiagonalSum(6);

            ////Console.WriteLine(param_1 + " " + param_12 + " " + param_2 + " " + param_22);
            //Console.WriteLine( param_2 + " " + param_22);
            #endregion

            #region

            //DrawPattern.Draw(9);

            #endregion


            #region Different ways to call a method in C#
            //Parent parent = new Parent();
            //parent.age = 30;
            //parent.name = "John";
            //parent.surname = "Wick";
            ////parent.Height //not accessible
            //Console.WriteLine($"{parent.ParentIntroduction()} : {parent.GetParentName()}");

            //Console.WriteLine("-----" + Environment.NewLine);

            //Child child = new Child();
            //child.name = "Doe";
            //child.age = 10;
            //child.height = 5;
            //child.surname = "Butcher";
            //Console.WriteLine($"{child.ChildIntroduction()} : {child.GetChildName()} : {child.GetParentName()} : {child.ParentIntroduction()}");

            //Console.WriteLine("-----" + Environment.NewLine);

            //Parent parent1 = new Child();
            //parent1.age = 40;
            //parent1.name = "Jane";
            //parent1.surname = "Doe";
            ////parent1.Height not accessible
            //Console.WriteLine($"{parent1.ParentIntroduction()} : {parent1.GetParentName()}");

            //Console.WriteLine("-----" + Environment.NewLine);

            //Child child1 = new Parent(); //Throwing Error
            //Child child1 = new Parent() as Child;   //Throwing Error
            //child1.name = "Darcy";
            //child1.age = 20;
            //child1.height = 6;
            //child1.surname = "Doe";
            //Console.WriteLine($"{child1.ChildIntroduction()} : {child1.GetChildName()} : {child1.GetParentName()} : {child1.ParentIntroduction()}");
            #endregion

            //dynamic dyn = 10;
            //dyn = "Hello"; // Allowed because the type is dynamic

            //var var1 = 10;
            //var1 = "Hello"; // Not allowed because the type is var

            #region Leet Code Problem | Array | 1. Two Sum
            _1TwoSum sum = new _1TwoSum();
            var indexes = sum.TwoSum(new int[] { 3, 3 }, 6);
            Console.WriteLine($"{indexes[0]} : {indexes[1]}");

            #endregion


            Console.ReadLine();

        }



    }
}
