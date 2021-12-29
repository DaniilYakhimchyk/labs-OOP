using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace Laba10
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            First();
            Second();
            Third();
        }

        private static void Third()
        {
            /*3.Создайте объект наблюдаемой коллекции ObservableCollection<T>.
             Создайте произвольный метод и  зарегистрируйте  его на  событие  CollectionChange. 
             Напишите демонстрацию с добавлением и удалением элементов. 
             В качестве типа Tиспользуйте свой класс из таблицы.*/

           
            var myCollection = new ObservableCollection<WebResourse>();
            myCollection.CollectionChanged += SayChange; 


            //добавляем элементы
            myCollection.Add(new WebResourse("T.by"));
            myCollection.Add(new WebResourse("A.by"));
            myCollection.Add(new WebResourse("C.by"));
            

            myCollection.RemoveAt(2);//удлаяем 2 элемент
        }

        private static void Second()
        {
            /*2.Создайте универсальную коллекцию в соответствии с вариантом задания и заполнить ее данными встроенного типа .Net(int, char,...).
             */
             

            Console.WriteLine("==================================");

            var universalCollection = new ConcurrentDictionary<string, int>();
            var enotherCollection = new Dictionary<string, int>();
            //добасвление
            universalCollection.TryAdd("A", 12);
            universalCollection.GetOrAdd("B", 12);
            universalCollection.TryAdd("C", 12);
            //вывод
            foreach (var keyValuePair in universalCollection) Console.WriteLine($"Key - {keyValuePair.Key} , Value - {keyValuePair.Value}");
            
            int tmp;
            universalCollection.TryRemove("A", out tmp);
            Console.WriteLine(tmp);

            foreach (var keyValuePair in universalCollection) enotherCollection.Add(keyValuePair.Key, keyValuePair.Value);
            foreach (var keyValuePair in enotherCollection) Console.WriteLine($"Key - {keyValuePair.Key} , Value - {keyValuePair.Value}");

            
        }

        private static void First()
        {
            /*Создайте класс по варианту, определите внем свойства и методы,*/
           


            
            var myCollection = new MyCollection<WebResourse>();
         
            var array = new WebResourse[5];
            Console.WriteLine("==================================");

            myCollection.Add(new WebResourse("T.by"));
            myCollection.Add(new WebResourse("A.by"));
            myCollection.Add(new WebResourse("B.by"));
            myCollection.Show();
            myCollection.RemoveAt(0);
            myCollection.Show();
            Console.WriteLine(myCollection[0]);


            myCollection.CopyTo(array, 2);
            foreach (var i in array) Console.Write($"{i} ");
            Console.WriteLine();

            myCollection.Show();
            Console.WriteLine("==================================");
            myCollection.Clear();
            myCollection.Show();

           
            
        }
        
        private static void SayChange(object sender, NotifyCollectionChangedEventArgs e)  //отображние эелементов
        {
            Console.WriteLine("==================================");
            if (e.Action == NotifyCollectionChangedAction.Add)
                Console.WriteLine("|Добавление завершено|");
            else if (e.Action == NotifyCollectionChangedAction.Remove) Console.WriteLine("|Удаление завершено|");
        }
    }
}