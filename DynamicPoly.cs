using System;

namespace NCC_Lab_Krisha
{
    class Animalia
    {
        // Virtual method that can be overridden
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }

    // Derived class
    class Puppy : Animalia
    {
        // Override the MakeSound method of the base class
        public override void MakeSound()
        {
            Console.WriteLine("Dog barks");
        }
    }
    // Derived class
    class Cats : Animalia
    {
        // Override the MakeSound method of the base class
        public override void MakeSound()
        {
            Console.WriteLine("Cat meows");
        }
    }

    class DynamicPoly
    {
        static void Main(string[] args)
        {
            // Creating objects of base and derived classes
            Animalia animal1 = new Animalia();
            Animalia animal2 = new Puppy(); // Upcasting
            Animalia animal3 = new Cats(); // Upcasting

            // Calling the MakeSound method on different objects
            animal1.MakeSound(); // Output: Animal makes a sound
            animal2.MakeSound(); // Output: Dog barks
            animal3.MakeSound(); // Output: Cat meows
            Console.WriteLine("\nLab No.: 6(b)\tName: Krisha Dhakal\tRoll No: 8/26445");
        }
    }

}
