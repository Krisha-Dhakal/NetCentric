using System;

namespace NCC_Lab_Krisha
{
    public partial class User
    {
        private string name;
        private string location;
        public User(string a, string b)
        {
            this.name = a;
            this.location = b;
        }
    }
    public partial class User
    {
        public void GetUserDetails()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Location: " + location);
        }
    }

    internal class PartialClass
    {
        static void Main(string[] args)
        {
            User u = new User("Krisha Dhakal", "Lalitpur");
            u.GetUserDetails();
            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine(); // the program will pause and wait for the user to input a line of text.
            Console.WriteLine("\nLab No.: 8(c)\tName: Krisha Dhakal\tRoll No: 8/26445");
        }
    }
}
