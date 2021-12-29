using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laba_5
{
    public class Gym<T>: IGym<T> where T: Inventar 
    {
        private int _money = 0;
        public List<T> list;

        public Gym()  //создаем конструктор
        {
            list = new List<T>();
        }

        public void Sort() //сортировка по цене
        {
            list = list.OrderByDescending(w => w.Price()).ToList();
        }

        public void Add(T item)  //добавление
        {
            
                list.Add(item);
                _money += item.Price();
            
        }
        public void Add(T item, int count) //добавление нескольких
        {
          
                for (int i = 0; i < count ; i++)
                {
                    list.Add(item);
                    _money += item.Price();
                }
            
        }

        public void Delete(int index)  //удаление
        {
            try
            {
                _money -= list[index].Price();
                list.RemoveAt(index);
            }
            catch
            {
                Console.WriteLine("Incorrect index!");
            }
        }

        public void Show()   //просмотр
        {
            foreach (T item in list)
                Console.Write("---"+item.ToString()+"---");

            Console.WriteLine();
        }

        public void ShowPrice()  //просмотр цены
        {
            Console.WriteLine($"Цена: {_money}$");
        }

    
    }
}
