using System;

namespace NCC_Lab_Krisha
{
    public class MyCollection
    {
        private int[] data;

        // Constructor to initialize the array
        public MyCollection(int size)
        {
            data = new int[size];
        }

        // Indexer declaration
        public int this[int index]
        {
            // Getter
            get
            {
                if (index < 0 || index >= data.Length)
                {
                    throw new IndexOutOfRangeException($"Index {index} is out of range.");
                }
                return data[index];
            }

            // Setter
            set
            {
                if (index < 0 || index >= data.Length)
                {
                    throw new IndexOutOfRangeException($"Index {index} is out of range.");
                }
                data[index] = value;
            }
        }
    }

    class IndexerIntDemo
    {
        static void Main(string[] args)
        {
            // Creating an instance of MyCollection with size 5
            MyCollection collection = new MyCollection(5);

            // Assigning values using indexer
            collection[0] = 10;
            collection[1] = 20;
            collection[2] = 30;
            collection[3] = 40;
            collection[4] = 50;

            // Accessing values using indexer and printing them
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Value at index {i}: {collection[i]}");
            }
            Console.WriteLine("\nLab No.: 4(a)\tName: Krisha Dhakal\tRoll No: 8/26445");
        }
    }
}
