using System;

namespace NCC_Lab_Krisha
{
    struct Book
    {
        public long isbn;
        public string title;
        public string author;
        public float price;
        public void DisplayBookDetail()
        {
            string detail = $"\tTitle: {title}\n\tAuthor: { author}\n\tISBN: { isbn}\n\tPrice: Rs.{ price}";
            Console.WriteLine(detail);
        }
    }
    internal class Struct
    {
        static void Main(string[] args)
        {
            Book b1;//without new keyword
            //initializing fields
            b1.isbn = 1298706785435;
            b1.title = "The Hobbit";
            b1.author = "J.R.R. Tolkien";
            b1.price = 1189.50f;
            Book b2 = new Book();//using new keyword
            b2.title = "The Alchemist";
            b2.isbn = 1298706785436;
            b2.author = "Paulo Coelho";
            b2.price = 1209.50f;
            Console.WriteLine("-------Detail of first book-----");
            b1.DisplayBookDetail();
            Console.WriteLine("\n-------Detail of second book-----");
            b2.DisplayBookDetail();
            Console.WriteLine("\nLab No.: 8(a)\tName: Krisha Dhakal\tRoll No: 8/26445");
        }
    }
}
