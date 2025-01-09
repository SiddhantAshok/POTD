using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFeatures.Features.CallingBehaviours
{
    internal class Child : Parent
    {
        public int height { get; set; }
        public Child()
        {
            Console.WriteLine("Child Constructor");
        }

        public string GetChildName()
        {
            return name;
        }

        public string ChildIntroduction()
        {
            return $"I am {name} and I am {age} years old.";
        }
    }
}
