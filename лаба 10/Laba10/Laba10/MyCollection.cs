using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Laba10
{
    public class MyCollection<T> : IList<T>
    {
        private T[] _content;


        public MyCollection()
        {
            Count = 0;
            _content = Array.Empty<T>();
        }

        public int Count { get; private set; }
        public bool IsReadOnly { get; } 

        public IEnumerator<T> GetEnumerator() //перебор элементов
        {
            for (var i = 0; i < Count; i++) yield return _content[i];
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(T item) //добавление
        {
            if (item == null)
                throw new NullReferenceException();

            var tmp = new T[Count + 1];
            _content.CopyTo(tmp, 0);
            _content = tmp;
            _content[Count] = item;
            Count++;
        }

        public void Clear()  //очистка
        {
            _content = Array.Empty<T>();
            Count = 0;
        }

       public bool Contains(T item) //проверка на наличие
        {
            for (var i = 0; i < Count; i++)
                if (Equals(_content[i], item))
                    return true;

            return false;
        }
      
        public void CopyTo(T[] array, int arrayIndex)
        {
            if (array.Length - arrayIndex < Count)
                throw new ArgumentOutOfRangeException();

            for (var i = 0; i < Count; i++) array[arrayIndex + i] = _content[i];
        }

        public bool Remove(T item)  //удаление
        {
            int numIndex = Array.IndexOf(_content, item);
            if (numIndex == -1)
                return false;
            _content = _content.Where((val, idx) => idx != numIndex).ToArray();
            Count--;
            return true;
        }

        public int IndexOf(T item) //поиск по индексу
        {
            for (var i = 0; i < Count; i++)
                if (Equals(_content[i], item))
                    return i;
            return -1;
        }

        public void Insert(int index, T item) //вставка
        {
            if (index < 0 || index > Count)
                throw new ArgumentOutOfRangeException();

            Count++;
            var tmp = new T[Count];
            _content.CopyTo(tmp, 0);
            _content = tmp;
            for (int i = Count - 1; i > index; i--) _content[i] = _content[i - 1];

            _content[index] = item;
        }

        public void RemoveAt(int index) //удаление по индексу
        {
            if (index < 0 && index >= Count) throw new ArgumentOutOfRangeException();

            _content = _content.Where((val, idx) => idx != index).ToArray();
            Count--;
        }

        public T this[int index]
        {
            get => _content[index];
            set => _content[index] = value;
        }

        public void Show() //вывод
        {
            

            foreach (var x1 in _content) Console.Write($"{x1.ToString()} ");
            Console.WriteLine();
            
        }

        
        
    }
}