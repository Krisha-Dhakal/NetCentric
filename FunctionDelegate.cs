using System;

namespace NCC_Lab_Krisha
{
    delegate void MyDelegate(string message);
    class FunctionDelegate
    {
        // Method that matches the delegate signature
        static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
        static void Main(string[] args)
        {
            // Create an instance of the delegate
            MyDelegate myDelegate = new MyDelegate(PrintMessage);

            // Invoke the delegate
            myDelegate("This is an example of Function Delegate.");
            Console.WriteLine("\nLab No.: 9(c)\tName: Krisha Dhakal\tRoll No: 8/26445");
        }
    }
}
