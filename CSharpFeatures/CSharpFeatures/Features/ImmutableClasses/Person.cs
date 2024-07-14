using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFeatures.ImmutableClasses
{
    //achieve immutability using private and readonly fields
    //public class Person
    //{
    //    // Private readonly fields
    //    private readonly string firstName;
    //    private readonly string lastName;
    //    private readonly int age;

    //    // Public properties with only getters
    //    public string FirstName => firstName;
    //    public string LastName => lastName;
    //    public int Age => age;

    //    // Constructor to initialize all properties
    //    public Person(string firstName, string lastName, int age)
    //    {
    //        this.firstName = firstName;
    //        this.lastName = lastName;
    //        this.age = age;
    //    }

    //    // Optionally, you can provide additional methods or functionality here

    //    // Example of a method that returns a new instance with modified age, because age cannot be modified of an existing instance
    //    public Person WithAge(int newAge)
    //    {
    //        return new Person(this.firstName, this.lastName, newAge);
    //    }
    //}


    //acieve immutability via auto-implemented properties with only getters and without using private and readonly fields
    public class Person
    {
        // Public properties with private setters
        public string FirstName { get; }
        public string LastName { get; }
        public int Age { get; }

        // Constructor to initialize properties
        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        // Method to create a new Person with a different age, because age cannot be modified of an existing instance
        public Person WithAge(int newAge)
        {
            return new Person(this.FirstName, this.LastName, newAge);
        }
    }
}
