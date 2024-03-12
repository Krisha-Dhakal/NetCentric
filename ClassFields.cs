using System;

namespace NCC_Lab_Krisha
{
    public class Animal
    {
        public string color = "blue";
    }
    public class Dog : Animal
    {
        string color = "red"; //same filed as parent
        public void showColor()
        {
            Console.WriteLine(base.color); //parent class color
            Console.WriteLine(color); //child class color
        }
    }
    class ClassFields
    {
        public static void Main()
        {
            Dog d = new Dog();
            d.showColor();
            Console.WriteLine("\nLab No.: 5(a)\tName: Krisha Dhakal\tRoll No: 8/26445");
        }
    }
}
