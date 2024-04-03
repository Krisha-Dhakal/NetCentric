using System;

namespace NCC_Lab_Krisha
{
    class LinqDemo
    {
        static void Main(string[] args)
        {
            //specify the data source.
            int[] scores = new int[] { 97, 92, 81, 60, 100 };

            //LINQ query expression
            var result1 = from scr in scores where scr > 80 select scr;
            //Execute the query
            Console.WriteLine("Scores greater than 80 are: ");
            foreach (int i in result1)
            {
                Console.WriteLine(i + " ");
            }
            //another LINQ
            var result2 = from scr in scores where scr > 80 orderby scr descending select scr;
            Console.WriteLine("\nScores greater than 80 in descending order : ");
            foreach (int i in result2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\nLab No.: 13\tName: Krisha Dhakal\tRoll No: 8/26445");
        }
    }
}
