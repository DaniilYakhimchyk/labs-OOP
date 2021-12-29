using System;
using System.Text;

namespace ConsoleApp2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "1 2 3";
            string b = "4 5 6";
            string c = "7 8 9";
            int result = String.Compare(a, b);
            if (result < 0)
            {
                Console.WriteLine("Строка a перед строкой b");
            }
            else if (result > 0)
            {
                Console.WriteLine("Строка a стоит после строки b");
            }
            else
            {
                Console.WriteLine("Строки a и b идентичны");
            }
            string s10 = String.Concat(a, b, c);
            Console.WriteLine(s10);
            Console.WriteLine(a.Insert(3, "456"));
            Console.WriteLine(s10.Remove(2, 6));
            string[] razd = s10.Split(' ');
            Console.WriteLine(razd[6]);
            //////////////////////////////////////////////////////////////////////////////////
            string nuul = null;
            bool name = string.IsNullOrEmpty(nuul);
            Console.WriteLine(name);
            string nuul2 = "";
            bool name2 = string.IsNullOrEmpty(nuul2);
            Console.WriteLine(name2);
            string nuul3 = "lkl";
            bool name3 = string.IsNullOrEmpty(nuul3);
            Console.WriteLine(name3);
            /////////////////////////////////////////////////////////////////////////////////
            StringBuilder sb = new StringBuilder("123456789");
            Console.WriteLine($"Длина строки: {sb.Length}");
            sb.Remove(2, 4);
            sb.Append("!");
            sb.Insert(0, "компьютерный ");
            Console.WriteLine(sb);

        }
    }
}
