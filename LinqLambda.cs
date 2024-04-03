using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace NCC_Lab_Krisha
{
    public delegate int SquareDelegate(int num);
    public delegate void HelloDelegate(string name);
    class LinqLambda
    {
        static void Main(string[] args)
        {
            LambdaDemo ld = new LambdaDemo();
            //statement lamda
            HelloDelegate hd = (name) => {
                string msg = "Hello " + name + " Good morning !"; Console.WriteLine(msg);
            };
            //expression lamda 
            SquareDelegate sd = (num) => num * num;
            hd("Krisha");
            int sqr = sd(8); Console.WriteLine("Square of 8 is " + sqr);
            Console.WriteLine("\nLab No.: 14(b)\tName: Krisha Dhakal\tRoll No: 8/26445");
        }
    }
}
