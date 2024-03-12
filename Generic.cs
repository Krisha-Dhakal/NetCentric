using System;
using System.Collections.Generic;

namespace NCC_Lab_Krisha
{
    class Generic
    {
        static void Main(string[] args)
        {
            // Create a list of integers
            List<int> numbers = new List<int>();

            // Add elements to the list
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);

            // Iterate over the list and print each element
            Console.WriteLine("Elements in the list:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            // Remove an element from the list
            numbers.Remove(2);

            // Check if an element exists in the list
            if (numbers.Contains(3))
            {
                Console.WriteLine("List contains 3");
            }

            // Find the index of an element in the list
            int index = numbers.IndexOf(4);
            Console.WriteLine("Index of 4: " + index);
            // Clear all elements from the list
            numbers.Clear();
            Console.WriteLine("Number of elements in the list after clearing: " + numbers.Count);
            Console.WriteLine("\nLab No.: 10(b)\tName: Krisha Dhakal\tRoll No: 8/26445");
        }

    }
}
