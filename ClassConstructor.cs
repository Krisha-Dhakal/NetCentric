using System;

namespace NCC_Lab_Krisha
{
    class DomesticAnimal
    {
        public string Species { get; set; }

        // Base class constructor
        public DomesticAnimal(string species)
        {
            Species = species;
            Console.WriteLine("Animal constructor called. Species: " + Species);
        }
    }
    class Dogs : DomesticAnimal
    {
        public string Breed { get; set; }

        // Derived class constructor using base keyword
        public Dogs(string species, string breed) : base(species)
        {
            Breed = breed;
            Console.WriteLine("Dog constructor called. Breed: " + Breed);
        }
    }

    class ClassConstructor
    {
        static void Main()
        {
            // Create an instance of the derived class (Dog)
            Dogs myDog = new Dogs("Canine", "Labrador");
            Console.WriteLine("\nLab No.: 5(c)\tName: Rubi Poudel\tRoll No: 19");
        }
    }
}
