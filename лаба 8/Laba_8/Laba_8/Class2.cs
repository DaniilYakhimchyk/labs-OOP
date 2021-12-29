using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Laba_8
{
    class infile
    {
        public static void Write(LinkedList<string> list)
        {
            using (StreamWriter a = new StreamWriter(@"D:\Учеба\2 курс\ООП\лаба 8\Laba_8\Laba_8\in.txt")) 
            {
                Node<string> temp = list.head;
                while (temp.Next != null)
                {
                    a.Write($"{temp.Data}|");
                    temp = temp.Next;
                }
                a.WriteLine(temp.Data);
            }  
        }
        public static void Read(LinkedList<string> list)
        {
            using (StreamReader a = new StreamReader(@"D:\Учеба\2 курс\ООП\лаба 8\Laba_8\Laba_8\in.txt"))
            {
                string[] items = a.ReadToEnd().Split("|");
                foreach(string item in items)
                {
                    list.Add(item);
                }
            }
        }
    }
}
