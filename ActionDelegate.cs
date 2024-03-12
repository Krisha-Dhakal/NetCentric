using System;

namespace NCC_Lab_Krisha
{
    class ActionDelegate
    {
        static void Main(string[] args)
        {
            // Example 1: Action with no parameters and no return type
            Action printHello = () => Console.WriteLine("Hello!");
            printHello(); // Invoke the action

            // Example 2: Action with parameters and no return type
            Action<string, int> printMessageAndNumber = (message, number) =>
            {
                Console.WriteLine(message);
                Console.WriteLine("Number: " + number);
            };
            printMessageAndNumber("This is Action Delegate.", 8); // Invoke the action
            Console.WriteLine("\nLab No.: 9(d)\tName: Krisha Dhakal\tRoll No: 8/26445");
        }

    }
}
