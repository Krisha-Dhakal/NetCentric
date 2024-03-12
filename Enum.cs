using System;
using System.Collections.Generic;
using System.Text;

namespace NCC_Lab_Krisha
{
    public enum Ritu
    {
        Basanta,
        Grishma,
        Barsha,
        Sharad,
        Hemanta,
        Shishir
    }
    public enum Courses { BIM = 300, CSIT, BCA, BBA = 400, BBM, BBS };
    internal class Enum
    {
        static void Main(string[] args)
        {
            int a = (int)Ritu.Grishma;
            int b = (int)Ritu.Shishir;
            Console.WriteLine("Integral value of {0} is {1}", Ritu.Grishma, a);
            Console.WriteLine("Integral value of {0} is {1}", Ritu.Shishir, b);
            Console.WriteLine("Integral values of elements of Courses enum: ");
            Console.WriteLine(Courses.BIM + " = " + (int)Courses.BIM);
            Console.WriteLine(Courses.CSIT + " = " + (int)Courses.CSIT);
            Console.WriteLine(Courses.BCA + " = " + (int)Courses.BCA);
            Console.WriteLine(Courses.BBA + " = " + (int)Courses.BBA);
            Console.WriteLine(Courses.BBM + " = " + (int)Courses.BBM);
            Console.WriteLine(Courses.BBS + " = " + (int)Courses.BBS);
            Console.WriteLine("\nLab No.: 8(b)\tName: Krisha Dhakal\tRoll No: 8/26445");
        }
    }
}
