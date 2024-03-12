using System;

namespace NCC_Lab_Krisha
{
    //declaring delegates
    public delegate void AddDelegate(int x, int y);
    public delegate string GreetingDelegate(string str);
    class DelegateDemo
    {
        public void AddNumbers(int a, int b)
        {
            Console.WriteLine("\tsum = " + (a + b));
        }
        public static string Greeting(string name)
        {
            return "\tHello " + name + ", Namaste!";
        }
        static void Main(string[] args)
        {
            DelegateDemo dd = new DelegateDemo();
            //creating delegate instances
            //setting target methods
            AddDelegate ad = new AddDelegate(dd.AddNumbers);
            GreetingDelegate gd = Greeting;
            //invoking delegates
            Console.WriteLine("Sum of two numbers(23, 73): ");
            ad.Invoke(23, 73);
            Console.WriteLine("\nGreetings: ");
            string msg = gd("Krisha");
            Console.WriteLine(msg);
            Console.WriteLine("\nLab No.: 9(a)\tName: Krisha Dhakal\tRoll No: 8/26445");
        }
    }
}
