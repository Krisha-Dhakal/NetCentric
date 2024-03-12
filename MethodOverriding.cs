using System;

namespace NCC_Lab_Krisha
{
    public class BaseClass
    {
        // Method to be overridden
        public virtual void Display()
        {
            Console.WriteLine("Inside BaseClass Display method");
        }

        // Method to be hidden/shadowed
        public void Show()
        {
            Console.WriteLine("Inside BaseClass Show method");
        }
    }
    public class DerivedClass : BaseClass
    {
        // Method overriding
        public override void Display()
        {
            Console.WriteLine("Inside DerivedClass Display method");
        }

        // Method hiding (shadowing)
        public new void Show()
        {
            Console.WriteLine("Inside DerivedClass Show method");
        }
    }

    class MethodOverriding
    {
        static void Main(string[] args)
        {
            BaseClass baseObj = new BaseClass();
            baseObj.Display(); // Calls BaseClass Display method
            baseObj.Show();    // Calls BaseClass Show method

            DerivedClass derivedObj = new DerivedClass();
            derivedObj.Display(); // Calls DerivedClass Display method (overridden)
            derivedObj.Show();    // Calls DerivedClass Show method (hidden/shadowed)

            // Upcasting
            BaseClass upcastedObj = new DerivedClass();
            upcastedObj.Display(); // Calls DerivedClass Display method (overridden)
            upcastedObj.Show();    // Calls BaseClass Show method (not overridden)
            Console.WriteLine("\nLab No.: 6(a)\tName: Krisha Dhakal\tRoll No: 8/26445");
        }

    }
}
