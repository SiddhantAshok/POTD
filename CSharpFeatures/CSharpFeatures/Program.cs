using CSharpFeatures.CollectionsManupulation;
using CSharpFeatures.ImmutableClasses;
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
            string counts = NumberOfAtoms.CountOfAtoms("Mg(OH)2");
            Console.WriteLine(counts);

            //Dictionary<string, int> map = new Dictionary<string, int>();

            //map["hello"] = 0;
            //map["hello"] = 1;
            //foreach (var item in map)
            //{
            //    Console.WriteLine(item.Key + item.Value);
            //}
            #endregion

            Console.ReadLine();

        }




    }
}
