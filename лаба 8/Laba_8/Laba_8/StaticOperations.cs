
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laba_8
{
    static class StaticOperations
    {
        public static int Sum(this LinkedList<string> list)  //функция сложения
        {
            int sum = 0;
            string test = list.ToString();
            var strArr = test.Split(" ");
            for (int i = 0; i < strArr.Count(); i++)
            {
                int len = strArr[i].Length;
                sum = sum + len;
            }

            return sum;
        }


        public static void ShortenString(this LinkedList<string> list, int length)
        {
            var current = list.head;
            while (current != null)
            {
                current.Data = current.Data.Substring(0, length);
                current = current.Next;
            }
        }

        public static string Tostring2(this LinkedList<string> list)
        {
            var res = "";
            for (Node<string> pA = list.head; pA != null; pA = pA.Next)
            {
                res += pA.Data + " ";
            }
            return res;

        }

        //разница между максимальной и минимальной строкой
        public static int Difference(this LinkedList<string> list)
        {
            string test = list.ToString();
            string[] strArr = test.Split(" ");
            string[] strArr2 = new string[strArr.Length - 1];
            Array.Copy(strArr, strArr2, strArr.Length - 1);


            var max = strArr2[0]; var min = strArr2[0];
            for (int i = 0; i < strArr2.Length; i++)
            {
                if (min.Length > strArr2[i].Length) min = strArr2[i];
                if (max.Length < strArr2[i].Length) max = strArr2[i];

            }

            return max.Length - min.Length;
        }

        //подсчет
        public static int CountOfS(this LinkedList<string> list)
        {
            string test = list.ToString();
            var strArr = test.Split(" ");
            return strArr.Count() - 1;
        }
    }
}
