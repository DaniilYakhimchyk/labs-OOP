using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Laba4Var8
{
    public class Set<T> : IEnumerable<T>
    {
    
        public List<T> _items = new List<T>();

        public int Count => _items.Count;

      
        public void Add(T item) // Добавление 
        {
            // Проверяем входные данные на пустоту.
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }
            
            // Множество может содержать только уникальные элементы,
            // поэтому если множество уже содержит такой элемент данных, то не добавляем его.
            if (!_items.Contains(item))
            {
                _items.Add(item);
            }
        }
      


        public void Remove(T item) // Удалить
        {
            // Проверяем входные данные на пустоту.
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            // Если коллекция не содержит данный элемент, то мы не можем его удалить.
            if (!_items.Contains(item))
            {
                throw new KeyNotFoundException($"Элемент {item} не найден в множестве.");
            }

            // Удаляем элемент из коллекции.
            _items.Remove(item);
        }

        public void ShowInfo(int x)
        {
            Console.Write($"{x}-е множество: ");
            foreach(var i in this)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
        }

        public static Set<T> Union(Set<T> set1, Set<T> set2) // Объединение 
        {
            // Проверяем входные данные на пустоту.
            if (set1 == null)
            {
                throw new ArgumentNullException(nameof(set1));
            }

            if (set2 == null)
            {
                throw new ArgumentNullException(nameof(set2));
            }

            // Результирующее множество.
            var resultSet = new Set<T>();

            // Элементы данных результирующего множества.
            var items = new List<T>();

            // Если первое входное множество содержит элементы данных,
            // то добавляем их в результирующее множество.
            if (set1._items != null && set1._items.Count > 0)
            {
                // т.к. список является ссылочным типом, 
                // то необходимо не просто передавать данные, а создавать их дубликаты.
                items.AddRange(new List<T>(set1._items));
            }

            // Если второе входное множество содержит элементы данных, 
            // то добавляем из в результирующее множество.
            if (set2._items != null && set2._items.Count > 0)
            {
                // т.к. список является ссылочным типом, 
                // то необходимо не просто передавать данные, а создавать их дубликаты.
                items.AddRange(new List<T>(set2._items));
            }

            // Удаляем все дубликаты из результирующего множества элементов данных.
            resultSet._items = items.Distinct().ToList();

            // Возвращаем результирующее множество.
            return resultSet;
        }

        
        //public static Set<T> Intersection(Set<T> set1, Set<T> set2)// Пересечение
        //{
    

        //    // Результирующее множество.
        //    var resultSet = new Set<T>();

        //    // Выбираем множество содержащее наименьшее количество элементов.
        //    if (set1.Count < set2.Count)
        //    {
        //        // Первое множество меньше.
        //        // Проверяем все элементы выбранного множества.
        //        foreach (var item in set1._items)
        //        {
        //            // Если элемент из первого множества содержится во втором множестве,
        //            // то добавляем его в результирующее множество.
        //            if (set2._items.Contains(item))
        //            {
        //                resultSet.Add(item);
        //            }
        //        }
        //    }
        //    else
        //    {
        //        // Второе множество меньше или множества равны.
        //        // Проверяем все элементы выбранного множества.
        //        foreach (var item in set2._items)
        //        {
        //            // Если элемент из второго множества содержится в первом множестве,
        //            // то добавляем его в результирующее множество.
        //            if (set1._items.Contains(item))
        //            {
        //                resultSet.Add(item);
        //            }
        //        }
        //    }

        //    // Возвращаем результирующее множество.
        //    return resultSet;
        //}

        
        public static Set<T> Difference(Set<T> set1, Set<T> set2)// Разность
        {
            // Проверяем входные данные на пустоту.
            if (set1 == null)
            {
                throw new ArgumentNullException(nameof(set1));
            }

            if (set2 == null)
            {
                throw new ArgumentNullException(nameof(set2));
            }

            // Результирующее множество.
            var resultSet = new Set<T>();

            // Проходим по всем элементам первого множества.
            foreach (var item in set1._items)
            {
                // Если элемент из первого множества не содержится во втором множестве,
                // то добавляем его в результирующее множество.
                if (!set2._items.Contains(item))
                {
                    resultSet.Add(item);
                }
            }

            // Проходим по всем элементам второго множества.
            foreach (var item in set2._items)
            {
                // Если элемент из второго множества не содержится в первом множестве,
                // то добавляем его в результирующее множество.
                if (!set1._items.Contains(item))
                {
                    resultSet.Add(item);
                }
            }

            // Удаляем все дубликаты из результирующего множества элементов данных.
            resultSet._items = resultSet._items.Distinct().ToList();

            // Возвращаем результирующее множество.
            return resultSet;
        }

       
        //public static bool Subset(Set<T> set1, Set<T> set2)// ПОдмножество
        //{

        //    // Перебираем элементы первого множества.
        //    // Если все элементы первого множества содержатся во втором,
        //    // то это подмножество. Возвращаем истину, иначе ложь.
        //    var result = set1._items.All(s => set2._items.Contains(s));
        //    return result;
        //}


        public static int operator <(Set<T> set1, Set<T> set2)
        {
            var arr = set1._items.ToArray() as int[];
          
            var subarr = set2._items.ToArray() as int[];
            
            int index = -1;
            for (int i = 0; i < arr.Length - subarr.Length + 1; i++)
            {
                index = i;
                for (int j = 0; j < subarr.Length; j++)
                {
                    if (arr[i + j] != subarr[j] )
                    {
                        index = -1;
                        break;
                    }
                }
                if (index >= 0)
                    return index;
            }
            return -1;

        }
        public static int operator >(Set<T> set1, Set<T> set2)
        {

            var arr = set1._items.ToArray() as int[];

            var subarr = set2._items.ToArray() as int[];
            
            
            int index = -1;
            for (int i = 0; i < arr.Length - subarr.Length + 1; i++)
            {
                index = i;
                for (int j = 0; j < subarr.Length; j++)
                {
                    if (arr[i + j] != subarr[j] )
                    {
                        index = -1;
                        break;
                    }
                }
                if (index >= 0)
                    return index;
            }
            return -1;

        }

        public static Set<T> operator *(Set<T> set1, Set<T> set2)
        {
            var resultSet = new Set<T>();

            // Выбираем множество содержащее наименьшее количество элементов.
            if (set1.Count < set2.Count)
            {
                // Первое множество меньше.
                // Проверяем все элементы выбранного множества.
                foreach (var item in set1._items)
                {
                    // Если элемент из первого множества содержится во втором множестве,
                    // то добавляем его в результирующее множество.
                    if (set2._items.Contains(item))
                    {
                        resultSet.Add(item);
                    }
                }
            }
            else
            {
                // Второе множество меньше или множества равны.
                // Проверяем все элементы выбранного множества.
                foreach (var item in set2._items)
                {
                    // Если элемент из второго множества содержится в первом множестве,
                    // то добавляем его в результирующее множество.
                    if (set1._items.Contains(item))
                    {
                        resultSet.Add(item);
                    }
                }
            }
            return resultSet;
        }

        public static bool operator <(Set<T> set, T d)
        {
            if (set._items.Contains(d)) return true;
            else return false;
        }
        public static bool operator >(Set<T> set, T d)
        {
            if (set._items.Contains(d)) return true;
            else return false;
        }


        public IEnumerator<T> GetEnumerator()
        {
            // Используем перечислитель списка элементов данных множества.
            return _items.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            // Используем перечислитель списка элементов данных множества.
            return _items.GetEnumerator();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Set<int> set = new Set<int>();
            set.Add(3);
            set.Add(2);
            set.Add(7);
            set.Add(9);
            bool b = set > 10;
            Console.WriteLine(b);

            Set<int> set2 = new Set<int>();
            set2.Add(-6);
            set2.Add(-2);
            set2.Add(7);
            int b2 = set > set2;
            set2.DelNumb();
            set2.ShowInfo(2);
                
           if (b2 >0)
            {
                Console.WriteLine("Является подстрокой");
            }
            else Console.WriteLine("Не является подстрокой");

            Set<int> set3 = new Set<int>();
            set3 = set * set2;
            set3.ShowInfo(3);

            Set<string> set4 = new Set<string>();
            set4.Add("H2e381llo");
            set4.Add("Worl4d3");
            set4.ShowInfo(4);
            char a=set4.LastNumb();
            
            Console.WriteLine(a);
            
        }
    }
}
