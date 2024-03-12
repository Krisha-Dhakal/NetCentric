using System;
using System.Collections.Generic;

namespace NCC_Lab_Krisha
{
    public class MyCollection<T>
    {
        private Dictionary<string, T> data;

        // Constructor to initialize the dictionary
        public MyCollection()
        {
            data = new Dictionary<string, T>();
        }

        // Indexer declaration with string type index
        public T this[string key]
        {
            // Getter
            get
            {
                if (!data.ContainsKey(key))
                {
                    throw new KeyNotFoundException($"Key {key} does not exist.");
                }
                return data[key];
            }

            // Setter
            set
            {
                data[key] = value;
            }
        }
    }

    class IndexerDemo
    {
        static void Main(string[] args)
        {
            // Creating an instance of MyCollection
            MyCollection<int> collection = new MyCollection<int>();

            // Assigning values using indexer
            collection["one"] = 1;
            collection["two"] = 2;
            collection["three"] = 3;

            // Accessing values using indexer and printing them
            Console.WriteLine($"Value at key 'one': {collection["one"]}");
            Console.WriteLine($"Value at key 'two': {collection["two"]}");
            Console.WriteLine($"Value at key 'three': {collection["three"]}");
            Console.WriteLine("\nLab No.: 4(b)\tName: Krisha Dhakal\tRoll No: 8/26445");
        }
    }
}
