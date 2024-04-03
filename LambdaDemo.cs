using System;

namespace NCC_Lab_Krisha
{
    public delegate string GreetDelegate(string name);
    internal class LambdaDemo
    {
        public string SayHello(string name)
        {
            return $"Hello {name}";
        }
        static void Main(string[] args)
        {
            LambdaDemo demo = new LambdaDemo();
            GreetDelegate gd = (name) =>
            {
                return $"Hello {name}";
            };
            string msg = gd("Krisha");
            Console.WriteLine(msg); // Add this line to display the greeting message
            Console.WriteLine("\nLab No.: 14(a)\tName: Krisha Dhakal\tRoll No: 8/26445");
        }
    }
}
