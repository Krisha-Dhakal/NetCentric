using System;

namespace NCC_Lab_Krisha
{
    class JaggedArray
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[3][]{
                          new int[] { 11, 21, 56, 78 },
                          new int[] { 2, 5, 6, 7, 98, 5 },
                          new int[] { 2, 5 }
                          };
            // Traverse array elements
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    System.Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nLab No.: 3\tName: Krisha Dhakal\tRoll No: 8/26445");
        }
    }
}
