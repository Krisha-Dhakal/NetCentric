using System;

namespace NCC_Lab_Krisha
{
    class DataStore<T>
    {
        private T[] _data = new T[10];
        public void AddOrUpdate(int index, T item)
        {
            if (index >= 0 && index < 10)
                _data[index] = item;
        }
        public T GetData(int index)
        {
            if (index >= 0 && index < 10)
                return _data[index];
            else
                return default(T);
        }
    }
    class GenericClass
    {
        static void Main(string[] args)
        {
            DataStore<string> cities = new DataStore<string>();
            cities.AddOrUpdate(0, "Kathmandu");
            cities.AddOrUpdate(1, "Pokhara");
            cities.AddOrUpdate(2, "Peris");
            Console.WriteLine(cities.GetData(1));

            DataStore<int> empIds = new DataStore<int>();
            empIds.AddOrUpdate(0, 50);
            empIds.AddOrUpdate(1, 65);
            empIds.AddOrUpdate(2, 89);
            Console.WriteLine(empIds.GetData(0));
            Console.WriteLine("\nLab No.: 11\tName: Krisha Dhakal\tRoll No: 8/26445");
        }
    }
}
