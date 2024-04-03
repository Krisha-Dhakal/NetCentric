using System;
using System.Threading.Tasks;

namespace NCC_Lab_Krisha
{
    class AsynchronousPro
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Start of the program.");

            // Call the asynchronous method
            await PerformAsyncTask();

            Console.WriteLine("End of the program.");
            Console.WriteLine("\nLab No.: 17\tName: Krisha Dhakal\tRoll No: 8/26445");
        }

        static async Task PerformAsyncTask()
        {
            Console.WriteLine("Start of the asynchronous task.");

            // Simulate a time-consuming operation
            await Task.Delay(3000); // Represents a 3-second delay

            Console.WriteLine("End of the asynchronous task.");
        }
    }
}
