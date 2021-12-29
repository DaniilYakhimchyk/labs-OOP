using System;

namespace Массивы2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[,] {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };
            int height = arr.GetLength(0);
            int width = arr.GetLength(1);
            for (int y = 0; y < height; y++)
            {
                for (int x1 = 0; x1 < width; x1++)
                {
                    Console.Write(arr[y, x1] + "\t");
                }
                Console.WriteLine();
            }
           
           

            string[] arrs7 = { "1word", "2word", "3word", "4word" };
            Console.WriteLine("Длина массива = " + arrs7.Length);
            for(int i=0;i <arrs7.Length;i++)
            {
                Console.WriteLine(arrs7[i]);
            }

            Console.Write("Введите позиию(1-4),а после значение:");
            int x = Convert.ToInt32(Console.ReadLine());
            string change = Convert.ToString(Console.ReadLine());
            for (int t = 0; t < arrs7.Length; t++)
            {
                if ((x - 1) == t) { arrs7[t] = change; }
                Console.Write(arrs7[t] + "\t");
            }
            Console.WriteLine();
            ////////////////////////////////////////////////
            int [][] myArray = new int[3][];
            myArray[0] = new int[4] { 1, 2, 3, 4 };
            myArray[1] = new int[2] { 1, 2 };
            myArray[2] = new int[3] { 1, 2, 5 };
            for(int l = 0; l < myArray.Length; l++)
            {
                for (int m = 0; m < myArray[l].Length; m++) 
                {
                    Console.Write(myArray[l][m] + "\t");
                }
                Console.WriteLine();
            }
            var arr2 = new[] { 1, 2, 3, 4, 5, 6 };
            var str2 = "HEllo";
        }
        
        
      


    }
}
