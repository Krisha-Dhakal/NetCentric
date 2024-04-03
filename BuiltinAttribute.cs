using System;

namespace NCC_Lab_Krisha
{
    class MyClass2
    {
        [Obsolete("This method is obsolete. Use NewMethod instead.")]
        public void OldMethod()
        {
            Console.WriteLine("This is the old method.");
        }

        public void NewMethod()
        {
            Console.WriteLine("This is the new method.");
        }
    }

    class BuiltinAttribute
    {
        static void Main()
        {
            MyClass2 myObject = new MyClass2();

            // Generates a compiler warning because OldMethod is marked as obsolete
            myObject.OldMethod();

            myObject.NewMethod(); // No warning
            Console.WriteLine("\nLab No.: 16(a)\tName: Krisha Dhakal\tRoll No: 8/26445");
        }
    }   
}
