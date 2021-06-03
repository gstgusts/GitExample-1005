using System;

namespace _2DArray_1005
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numbers = new int[4, 2];

            numbers[0, 0] = 13;
            numbers[1, 0] = 10;

            Print2DArray(numbers);

            Console.WriteLine(numbers[1, 0]);

            int[] numbers2 = { 1, 6, 7 };

            int[,] numbers3 = new int[,] { { 4, 7, 9 }, { 1, 5, 8 } };

            Print2DArray(numbers3);
        }

        private static void Print2DArray(int[,] numbers)
        {
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.WriteLine($"{i}-{j}={numbers[i, j]}");
                }
            }
        }
    }
}
