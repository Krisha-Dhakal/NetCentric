using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace NCC_Lab_Krisha
{
    class ThrowHandle
    {
        static void DisplayAge(int age)
        {
            if (age > 0)
            {
                Console.WriteLine("Age is: " + age);
            }
            else
            {
                throw new ArithmeticException("Age cannot be Negative !!!");
            }
        }
        static void Main(string[] args)
        {
            try
            {
                DisplayAge(21);
                DisplayAge(-2);
            } 
            catch(ArithmeticException e) 
            {   
                Console.WriteLine("Exception caught: " + e.Message);
            }
            Console.WriteLine("\nLab No.: 15(b)\tName: Krisha Dhakal\tRoll No: 8/26445");
        }
    }
}
