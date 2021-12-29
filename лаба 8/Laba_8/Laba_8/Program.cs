
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Laba_8
{
    public class Node<T>
    {


        public Node(T data)
        {
            Data = data;
        }
        public Node(T data, Node<T> next)
        {
            Data = data;
            Next = next;
        }
        public T Data { get; set; }  //свойства
        public Node<T> Next { get; set; }
        public Node<T> SetNextNode(Node<T> node) => Next = node;
    }

    public class Owner
    {
        private string _name;
        private string _organization;
        private static int Id;

        public Owner(string name, string organization)
        {
            this._name = name;
            this._organization = organization;
            Id++;
        }
        public void Print()
        {
            Console.WriteLine($"ID: {Id}\n" +
                $"Name: {_name}\n" +
                $"Organization: {_organization}");
        }
    }

    public class Date
    {
        private DateTime _time;

        public Date()
        {
            _time = DateTime.Now;
        }

        public void ShowDate()
        {
            Console.WriteLine(_time);
        }
    }

    ///////////////////////////////
    public class LinkedList<T>:Iin<T> where T:class
    {
        public Node<T> head;
        public Node<T> tail;
        int count;


        public T this[int index]
        {
            get
            {
                if (index > count - 1 || index < 0) throw new IndexException("Error!");
                Node<T> temp = head;
                for (int i=0; i < index; i++)
                {
                    temp = temp.Next;
                }
                return temp.Data;
            }
            set
            {
                if (index > count - 1 || index < 0) throw new IndexException("Error!");
                Node<T> temp = head;
                for (int i = 0; i < index; i++)
                {
                    temp = temp.Next;
                }
                temp.Data = value;
            }
        }





        public void Add(T data)// добавление элемента
        {
            Node<T> node = new Node<T>(data);

            if (head == null)
                head = node;
            else
                tail.Next = node;
            tail = node;

            count++;
        }

        public void ShowInfo() //Вывод 
        {
            Node<T> node = head;
            while (node.Next != null)
            {
                Console.Write(node.Data + " --> ");
                node = node.Next;
            }
            Console.WriteLine(node.Data + "\n");
        }

        public bool Remove(T data) //Удаление по элементу
        {
            Node<T> current = head;
            Node<T> previous = null;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    // Если узел в середине или в конце
                    if (previous != null)
                    {

                        // убираем узел current, теперь previous ссылается не на current, а на current.Next
                        previous.Next = current.Next;

                        // Если current.Next не установлен, значит узел последний,
                        // изменяем переменную tail
                        if (current.Next == null)
                            tail = previous;
                    }
                    else
                    {
                        // если удаляется первый элемент
                        // переустанавливаем значение head

                        head = head.Next;
                        // если после удаления список пуст, сбрасываем tail
                        if (head == null)
                            tail = null;
                    }
                    count--;
                    return true;
                }
                previous = current;
                current = current.Next;
            }
            return false;
        }

        public void Remove(int index)//Удаление по индексу 
        {
            if (this.count == 0)
            {
                Console.WriteLine("Список пуст!");
            }
            if (this.count == 1)
            {
                head = null;
            }
            if (index == 1)
            {
                Console.WriteLine($"Узел {head.Data} удалён!");
                head = head.Next;
                return;
            }

            Node<T> node = head;
            Node<T> nextNode = head.Next;

            for (int i = 0; i < index - 2; i++)
            {
                node = node.Next;
                nextNode = nextNode.Next;
            }
            Console.WriteLine($"Узел {nextNode.Data} удалён!");
            node.SetNextNode(nextNode.Next);
        }




        public override string ToString()
        {
            var res = "";
            for (Node<T> pA = head; pA != null; pA = pA.Next)
            {
                res += pA.Data + " ";
            }
            return res;
        }



        #region 
        //Перегрузка для объединения лвух списков
        public static LinkedList<T> operator +(LinkedList<T> A, LinkedList<T> B)
        {
            LinkedList<T> list = new LinkedList<T>();

            for (Node<T> p = A.head; p != null; p = p.Next)
                list.Add(p.Data);
            for (Node<T> p = B.head; p != null; p = p.Next)
                list.Add(p.Data);
            return list;
        }

        //Перегрузка для реверсивного списка
        public static LinkedList<string> operator !(LinkedList<T> A)
        {

            string test = A.ToString();
            var strArr = test.Split(" ");
            string[] strArr2 = new string[strArr.Length - 1];
            Array.Copy(strArr, strArr2, strArr.Length - 1);
            LinkedList<string> list0 = new LinkedList<string>();
            for (int i = strArr2.Length - 1; i > -1; i--)
            {

                string temp = strArr2[i];
                //strArr2[i] = null;
                list0.Add(temp);
            }



            return list0;
        }




        public static bool operator !=(LinkedList<T> A, LinkedList<T> B)
        {

            return A.ToString() != B.ToString();
        }
        public static bool operator ==(LinkedList<T> A, LinkedList<T> B)
        {
            return A.ToString() == B.ToString();
        }

        public static LinkedList<T> operator <(LinkedList<T> A, LinkedList<T> B)
        {
            return A + B;
        }

        public static LinkedList<T> operator >(LinkedList<T> A, LinkedList<T> B)
        {
            return B + A;
        }

        #endregion



        public class Owner
        {
            string id;
            string name;
            string edition;

            public Owner(string _ID, string _NAME, string _EDITION)
            {
                id = _ID;
                name = _NAME;
                edition = _EDITION;
            }
        }
        public class Date
        {
            DateTime time = new DateTime();

            public DateTime Time { get { return time; } set { this.time = value; } }
            public Date(DateTime time)
            {
                if (time != null)

                    this.time = time;
                else
                    this.time = DateTime.Now;
            }
        }
    }



    class Program
    {


        static void Main(string[] args)
        {
            try
            {


                //1 список
                LinkedList<string> list1 = new LinkedList<string>();
                Console.Write("1й список: ");
                list1.Add("word1");
                list1.Add("word2");
                list1.Add("word3");
                list1.Add("word4");
                list1.ShowInfo();

                //реверсивный первый список
                LinkedList<string> list01 = new LinkedList<string>();
                Console.WriteLine("Реверсивный 1й список:");
                list01 = !list1;
                list01.ShowInfo();

                //2 список
                Console.Write("\n\n\n");
                LinkedList<string> list2 = new LinkedList<string>();
                Console.Write("2й список: ");
                list2.Add("word5");
                list2.Add("word6");
                list2.Add("word7");
                list2.Add("word8");
                list2.ShowInfo();



                Console.Write("\n\n\n");
                //объединение списсков           
                LinkedList<string> list12 = new LinkedList<string>();
                Console.Write("\nОбъединение 1 и 2 списков(2й + 1й): ");
                list12 = list1 > list2;
                list12.ShowInfo();
                LinkedList<string> list012 = new LinkedList<string>();
                Console.Write("\nОбъединение 1 и 2 списков(1й + 2й): ");
                list012 = list1 < list2;
                list012.ShowInfo();
                //----------------------------------------




                Console.Write("\n\n\n");

                if (list1 == list2) Console.WriteLine("\nРавенство 1 и 2 списков:\n------Списки равны------\n"); else if (list1 != list2) Console.WriteLine("\nРавенство 1 и 2 списков:\n------Списки не равны------\n");
                LinkedList<string> list11 = new LinkedList<string>();
                Console.Write("Список для сравнения с 1м: ");
                list11.Add("word1");
                list11.Add("word2");
                list11.Add("word3");
                list11.Add("word4");
                list11.ShowInfo();
                if (list1 == list11) Console.WriteLine("Равенство 1 и идентичного ему списков:\n------Списки равны------"); else if (list1 != list11) Console.WriteLine("\nРавенство 1 и 2 списков:\n------Списки не равны------");






                LinkedList<string> list3 = new LinkedList<string>();
                Console.Write("\n\n\n3й список: ");
                list3.Add("Hello");
                list3.Add("Hell");
                list3.Add("DontBe3Sad");
                list3.Add("HaveAGoodTime51");
                list3.ShowInfo();
                Console.WriteLine($"Общая длина элементов списка:{list3.Sum()}");
                Console.WriteLine($"Разница между длинами максимальной и минимальной строк: {list3.Difference()}");
                Console.WriteLine($"В списке {list3.CountOfS()} элементов(a)");



                Console.Write("\n\n\n");


                Owner own = new Owner("Daniil", "BSTU");
                own.Print();

                Date d = new Date();
                d.ShowDate();

                Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");
                Console.Write("\n\n\n");
                Console.WriteLine(list3.ToString() + "\t\t" + list3.Tostring2());





                Console.WriteLine("****************************" + list1[0]);
                //*Console.WriteLine("****************************" + list1[-1]);


                LinkedList<Inventar> list10 = new LinkedList<Inventar>();
                list10.Add(new Bars());
                list10.Add(new Bench());
                list10.ShowInfo();
                infile.Write(list1);    //чтение 
            }
            catch (IndexException parm)
            {
                Console.WriteLine(parm);
                
            }
            finally
            {
                Console.WriteLine("Hello!");
            }
        }
    }
}