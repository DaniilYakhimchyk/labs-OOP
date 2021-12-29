using System;
using System.Linq;

namespace кортежи
{
    class Program
    {
        static void Main(string[] args)
        {
            (int, string, char, string, ulong) pop = (3, "Лукашенко наш ", '<', "президент", 7);
            Console.WriteLine(pop);
            Console.WriteLine(pop.Item3 + "" + pop.Item1);
            ////////////////////////////////////////

            (int a, byte b) left = (5, 10);
            (long a, int b) right = (5, 10);
            Console.WriteLine(left == right);  // output: True
            Console.WriteLine(left != right);
            ///////////////////////////////////////////////////////////////
            int[] arg = { 1, -9, 80, 76, -44 };
            foreach (int i in arg) Console.Write($"{i} \t");
            Console.WriteLine();
            /////////////////////////////////////////////////////////////////
            var (min, max, sum, fl) = GetTuple(arg, "Hello");
            Console.Write("min:" + min + "\t max:" + max + "\tsum:" + sum + "\tletter: " + fl);
            static (int min, int max, int sum, string f1) GetTuple(int[] arg, string v)
            {
                
                string str;
               
                var result = (min: arg.Min(), max: arg.Max(), sum: arg.Sum(), f1: v.Remove(1, v.Length - 1));
                return result;
            }
            ////////////////////////////////////////////////////////////////
            var intArr = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            var funcStr = "abcd";

            Console.WriteLine();
            #region 1
            void CheckedTest()
            {
                try
                {
                    int pre = int.MaxValue;
                    int pres = int.MaxValue;
                    checked

                    {
                        int rez = pre + pres;
                        Console.WriteLine("a+b= " + rez + "\n");
                    }
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Переполнение \n");
                }
            }
            CheckedTest();
            void UnCheckedTest()
            {
                try
                {
                    int pre = int.MaxValue;
                    int pres = int.MaxValue;
                    unchecked
                    {
                        int rez = pre + pres;
                        Console.WriteLine("a+b= " + rez + "\n");
                    }
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Переполнение");
                }
            }
            UnCheckedTest();

            #endregion


        }

        private static (int, int) GetValues()
        {
            var nums = (1, 3);
            return nums;
        }
    }

    }

