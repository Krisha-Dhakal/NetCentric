using System;

namespace NCC_Lab_Krisha
{
    public class Person
    {
        // Auto-implemented Property
        public string Name { get; set; }
        // Read-only Property
        public int Age { get; }

        // Constructor to initialize the read-only property
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
    class Property
    {
        static void Main(string[] args)
        {
            // Creating an object of Person class
            Person person = new Person("Levi", 30);

            // Using auto-implemented property
            Console.WriteLine($"Name: {person.Name}");

            // Using read-only property
            Console.WriteLine($"Age: {person.Age}");
            Console.WriteLine("\nLab No.: 2\tName: Krisha Dhakal\tRoll No: 8/26445");
        }

    }
}
