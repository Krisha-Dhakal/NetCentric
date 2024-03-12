using System;

namespace NCC_Lab_Krisha
{
    abstract class Shape
    {
        public abstract double Area();
    }
    class Rectangle : Shape
    {
        public double Length
        {
            get;
            set;
        }
        public double Width
        {
            get;
            set;
        }
        public override double Area() => Length * Width;
    }

    class AbstractClass
    {
        static void Main(string[] args)
        {
            var rectangle = new Rectangle { Length = 5, Width = 4 };
            Console.WriteLine($"Area of rectangle: {rectangle.Area()}");
            Console.WriteLine("\nLab No.: 7(a)\tName: Krisha Dhakal\tRoll No: 8/26445");
        }
    }
}
