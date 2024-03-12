using System;

namespace NCC_Lab_Krisha
{
    public class MyClass
    {
        // Default Constructor
        public MyClass()
        {
            Console.WriteLine("Default Constructor Called");
        }

        // Parameterized Constructor
        public MyClass(int value)
        {
            Console.WriteLine("Parameterized Constructor Called with value: { value}");
        }

        // Copy Constructor
        public MyClass(MyClass original)
        {
            Console.WriteLine("Copy Constructor Called ");
        }

        // Static Constructor
        static MyClass()
        {
            Console.WriteLine("Static Constructor Called ");
        }

        // Private Constructor
        private MyClass(string message)
        {
            Console.WriteLine("Private Constructor Called with message: { message}");
        }
    }
    class Constructor
    {
        static void Main(string[] args)
        {
            // Default Constructor

            MyClass obj1 = new MyClass();

            // Parameterized Constructor
            MyClass obj2 = new MyClass(10);

            // Copy Constructor
            MyClass obj3 = new MyClass(obj1);

            // Static Constructor (Automatically called before any instance is created)
            // Note: Static constructor is called only once per type, regardless of the number of instances.
            // It is called automatically before any static members are accessed or any objects of the type are created.

            // Private Constructor - Can&#39;t be called from outside the class
            //MyClass obj4 = new MyClass("Hello"); // This will result in a compile-time error because the constructor is private
            Console.WriteLine("\nLab No.: 1\tName: Krisha Dhakal\tRoll No: 8/26445");
        }
    }
}
