using System;
using System.IO;

namespace NCC_Lab_Krisha
{
    class FileIO
    {
        static void Main()
        {
            Console.WriteLine("Enter text to write to file (press Enter to finish):");

            // Prompt user for input
            string input = Console.ReadLine();

            // Path to the file
            string filePath = "output.txt";

            // Write input to file
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                while (!string.IsNullOrEmpty(input))
                {
                    writer.WriteLine(input);
                    input = Console.ReadLine(); // Continue reading input until Enter key is pressed
                }
            }
            Console.WriteLine("Text written to file successfully.");
            Console.WriteLine("\nLab No.: 12\tName: Krisha Dhakal\tRoll No: 8/26445");
        }
    }
}
