using System;
namespace NCC_Lab_Krisha
{
    public class Animals
    {
        public virtual void eat()
        {
            Console.WriteLine("\teating...");
        }
    }
    public class Cat : Animals
    {
        public override void eat()
        {
            base.eat();
            Console.WriteLine("\teating bread...");
        }
    }
    class ClassMethod
    {
        public static void Main()
        {
            Cat d = new Cat();
            Console.WriteLine("Dog is");
            d.eat();
            Console.WriteLine("\nLab No.: 5(b)\tName: Krisha Dhakal\tRoll No: 8/26445");
        }        
    }
}
