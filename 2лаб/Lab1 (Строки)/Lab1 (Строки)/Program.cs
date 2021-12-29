using System;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = "Hello", second = ",World", third = "!!!", first1 = "Laba  ", first2 = "izi ";
            string c = String.Concat(first, second);

            if (first == second) Console.WriteLine("true"); else Console.WriteLine("false");
            string f1 = "D:\\ПроектыКЯР\\LP_Lab14\\Laba_1\\log.txt";
            Console.WriteLine(f1);
            Console.WriteLine(c + third);  //Конкатенация
            string res = c.Remove(6);//удаление символов из строки 
            Console.WriteLine((res + third).Insert(6, (first1 + first2))); // вставка строки на определённую позицию в строке 
            string hell = res.Substring(0, 4) + third + first1 + first2;// Извлечение из строки(разбиение на слова)
            Console.WriteLine(hell);
            Console.WriteLine(hell.Replace("izi", "ne izi"));// Замена
            string first4 = string.Copy(first1 + "ne " + first2);
            int x = 123;
            Console.WriteLine(first4);
            string last = $"ТЕкст + переменные или значения {x / 3}";//Интерполированной строкой в C# называется строка перед которой расположен символ $.
            Console.WriteLine(last);
            Console.WriteLine("------------------------------------------------------------------------------");
            bool Test(string s)
            {
                bool result;
                result = s == null || s == string.Empty;
                return result;
            }

            string s1 = null;
            string s2 = "";
            string s3 = "dsad";
            Console.WriteLine(Test(s1));
            Console.WriteLine(Test(s2));
            Console.WriteLine(Test(s3));
            string s4 = s1 ?? "hi";
            Console.WriteLine(s4);/*Оператор ?? называется оператором null-объединения.
                                   * Он применяется для установки значений по умолчанию для типов, которые допускают значение null.
                                   * Оператор ?? возвращает левый операнд, если этот операнд не равен null. Иначе возвращается правый операнд.*/
            Console.WriteLine("------------------------------------------------------------------------------");
            StringBuilder sb = new StringBuilder("Типо строка для удаления и добавления ");
            Console.WriteLine($"Длина строки: {sb.Length}");
            sb.Append("!!!");
            Console.WriteLine(sb);
            sb.Insert(4, " [опа]");
            sb.Remove(22, 8);
            Console.WriteLine(sb);
            char a, b;
            ab(out a, out b);
            if (a == b)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }

        private static void ab(out char a, out char b)
        {
            a = 'k';
            b = Convert.ToChar(Console.ReadLine());
        }


    }
}
