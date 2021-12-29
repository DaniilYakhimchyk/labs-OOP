using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = { { 12, 11, 103 }, { 44, 525, 613 }, { 47, 558, 129 }, { 130, 111, 122 } };

            int rows = arr.GetUpperBound(0) + 1;
            Console.WriteLine(rows);
            int columns = arr.GetUpperBound(1) + 1;
            // или так
            // int columns = mas.GetUpperBound(1) + 1;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{arr[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("--------------------------------------------------");

            string[] arrs = { "1word", "2word", "3word", "4word" };
            for (int k = 0; k < arrs.Length; k++)
                Console.Write(arrs[k] + "\t");
            Console.WriteLine();
            Console.WriteLine($"Длина массива:{arrs.Length}");


            Console.Write("Введите позиию(1-4),а после значение:");
            int x = Convert.ToInt32(Console.ReadLine());
            string change = Convert.ToString(Console.ReadLine());
            for (int t = 0; t < arrs.Length; t++)
            {
                if ((x - 1) == t) { arrs[t] = change; }
                Console.Write(arrs[t] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------");

            int[][] nums = new int[3][];
            nums[0] = new int[2] { 1, 2 };          // выделяем память для первого подмассива
            nums[1] = new int[3] { 1, 2, 3 };       // выделяем память для второго подмассива
            nums[2] = new int[4] { 1, 2, 3, 4 };

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums[i].Length; j++)
                {
                    Console.Write($"{nums[i][j]} \t");
                }
                Console.WriteLine();
            }


            var arr2 = new[] { 1, 2, 3, 4, 5, 6 };
            var str2 = "HEllo";
        }
    }
}
