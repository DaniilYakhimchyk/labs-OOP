using System;
using System.Linq;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            (int, string, char, string, ulong) person = (23, "Vitya", 'A', "Slemnyov", 8);
            Console.WriteLine(person);
            Console.WriteLine($"Age:{person.Item1}\nNAme:{person.Item2}");
            string a = person.Item4 + " " + person.Item2;
            Console.WriteLine(a);
            Console.WriteLine("-----------------Raspakovka prim---------------");
            var tuple = GetValues();
            Console.WriteLine(tuple.Item1 + "+" + tuple.Item2 + "=4");

            int[] arg = { 1, -9, 80, 76, -44 };
            foreach (int i in arg) Console.Write($"{i} \t");
            Console.WriteLine();
            var (min, max, sum, fl) = GetTuple(arg, "Hello");
            Console.Write("min:" + min + "\t max:" + max + "\tsum:" + sum + "\tletter: " + fl);
            static (int min, int max, int sum, string f1) GetTuple(int[] arg, string v)
            {
                //int fmn = arg[0], fmx = arg[0], sm = 0;
                string str;
                //str = v.Remove(1, v.Length - 1);
                //for (int i = 0; i < arg.Length; i++)
                //{
                //    if (fmn > arg[i]) fmn = arg[i];
                //    if (fmx < arg[i]) fmx = arg[i];
                //    sm += arg[i];
                //}
                var result = (min: arg.Min(), max: arg.Max(), sum: arg.Sum(), f1: v.Remove(1, v.Length - 1));
                return result;
            }

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
