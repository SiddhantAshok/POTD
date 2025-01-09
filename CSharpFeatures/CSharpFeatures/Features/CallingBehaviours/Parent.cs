using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFeatures.Features.CallingBehaviours
{
    internal class Parent
    {
        public int age { get; set; }
        public string name { get; set; }
        public string surname { get; set; }

        public Parent()
        {
            Console.WriteLine("Parent Constructor");
        }

        public string GetParentName()
        {
            return name;
        }

        public string ParentIntroduction()
        {
            return $"I am {name} and I am {age} years old.";
        }
    }
}
