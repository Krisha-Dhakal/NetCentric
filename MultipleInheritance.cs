using System;
using System.Collections.Generic;
using System.Text;

namespace NCC_Lab_Krisha
{
    interface Printable
    {
        void Print();
    }
    interface Drawable
    {
        void Draw();
    }
    public class Test : Printable, Drawable // multiple inheritance
    {
        public void Print()
        {
            Console.WriteLine("Printing");
        }
        public void Draw()
        {
            Console.WriteLine("Drawing");
        }
    }
    class MultipleInheritance
    {
        static void Main(string[] args)
        {
            Test t1 = new Test();
            t1.Draw();
            t1.Print();
            Console.WriteLine("\nLab No.: 7(c)\tName: Krisha Dhakal\tRoll No: 8/26445");
        }
    }
}
