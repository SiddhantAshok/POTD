using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFeatures.StaticAndInstanceConstructorInAClass
{
    class StaticAndInstanceTogetherClass
    {
        // Static field
        private static int staticField;

        // Instance field
        private int instanceField;

        // Static constructor
        static StaticAndInstanceTogetherClass() // doesn't take parameters 
        {
            staticField = 42;
            Console.WriteLine("Static constructor called. Static field initialized.");
        }

        // Instance constructor
        public StaticAndInstanceTogetherClass(int instanceField)
        {
            this.instanceField = instanceField;
            Console.WriteLine("Instance constructor called. Instance field initialized.");
        }

        public void DisplayFields()
        {
            Console.WriteLine($"Static field value: {staticField}, Instance field value: {instanceField}");
        }
    }
}
