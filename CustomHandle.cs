using System;

namespace NCC_Lab_Krisha
{
    public class CustomHandle
    {
        static void Main(string[] args)
        {
            Temperature temp = new Temperature();
            try
            {
                temp.ShowTemp(); // corrected method name to follow conventions
            }
            catch (TempIsZeroException e)
            {
                Console.WriteLine("TempIsZeroException: {0}", e.Message);
            }
            Console.ReadKey();
            Console.WriteLine("\nLab No.: 15(c)\tName: Krisha Dhakal\tRoll No: 8/26445");
        }
    }
    public class TempIsZeroException : Exception
    {
        public TempIsZeroException(string message) : base(message)
        {
        }
    }
    public class Temperature
    {
        int temperature = 0;
        public void ShowTemp() // corrected method name to follow conventions
        {
            if (temperature == 0)
            {
                throw new TempIsZeroException("Zero Temperature found");
            }
            else
            {
                Console.WriteLine("Temperature: {0}", temperature);
            }
        }
    }
}
