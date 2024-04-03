using System;
namespace NCC_Lab_Krisha
{
    // Define a custom attribute class
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    public sealed class MyCustomsAttribute : Attribute
    {
        public string Description { get; }

        public MyCustomsAttribute(string description)
        {
            Description = description;
        }
    }

    // Apply the custom attribute to a class
    [MyCustomsAttribute("This is a sample class with a custom attribute.")]
    public class MyClass1
    {
        public void SomeMethod()
        {
            Console.WriteLine("Executing SomeMethod in MyClass.");
        }
    }
    class CustomAttribute
    {
        static void Main()
        {
            // Retrieve custom attributes applied to MyClass
            Type type = typeof(MyClass1);
            object[] attributes = type.GetCustomAttributes(typeof(MyCustomsAttribute), false);

            if (attributes.Length > 0)
            {
                MyCustomsAttribute customAttribute = (MyCustomsAttribute)attributes[0];
                Console.WriteLine($"Description: {customAttribute.Description}");
            }

            MyClass1 myObject = new MyClass1();
            myObject.SomeMethod();
            Console.WriteLine("\nLab No.: 16(b)\tName: Krisha Dhakal\tRoll No: 8/26445");
        }
    }
}
