using System;
namespace NCC_Lab_Krisha
{
    interface IExample
    {
        void ExampleMethod();
    }
    class ExampleClass : IExample
    {
        public void ExampleMethod()
        {
            Console.WriteLine("This is an example method.");
        }
    }


    class Interface
    {
        static void Main(string[] args)
        {
            // Create an instance of the class
            ExampleClass exampleObj = new ExampleClass();

            // Call the method through the interface reference
            exampleObj.ExampleMethod();
            Console.WriteLine("\nLab No.: 7(b)\tName: Krisha Dhakal\tRoll No: 8/26445");
        }

    }
}
