﻿using System;

namespace Laba9
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            First();
            Second();
        }

        private static void Second()
        {
            /*2. Создайте пять методов пользовательской обработки строки (например,
                удаление знаков препинания, добавление символов, замена на заглавные,
                удаление лишних пробелов и т.п.). Используя стандартные типы делегатов
                (Action, Func) организуйте алгоритм последовательной обработки строки
                написанными вами методами. Далее приведен перечень заданий.*/

          

           Func<string, string> A;
            var str = "abc   ,. de f,,,, GH";
            Console.WriteLine($"\n\n\nCтрока: {str}");

            A = StringEditor.RemovePunctuation;
            str = A(str);
            Console.WriteLine($"{A.Method.Name}: {A(str)}");


            A = StringEditor.ToUpper;
            str = A(str);
            Console.WriteLine($"{A.Method.Name}: {str}");

            A = StringEditor.ToLower;
            str = A(str);
            Console.WriteLine($"{A.Method.Name}: {str}");

            A = StringEditor.RemoveSpace;
            str = A(str);
            Console.WriteLine($"{A.Method.Name}: {str}");

            A = StringEditor.AddExclamationMark;
            str = A(str);
            Console.WriteLine($"{A.Method.Name}: {str}");

            Console.WriteLine(str);
        }

        private static void First()
        {
            /*Создать  класс  Пользователь с событиями upgrade и work.
            В main создать некоторое количество объектов(ПО). Подпишите объекты на события произвольным образом. 
            Реакция на события  может быть следующая: обновление версии, вывод сообщений и т.п. 
             Проверить результаты изменения объектов после наступления событий.*/
            
            //Создаем экземпляры
            var firstSoftware = new Software("Visual Studio");
            var secondSoftware = new Software("Visual Studio code");

            User.OnUpgrade += secondSoftware.ChangeVersion;
            secondSoftware.ShowInfo();
            firstSoftware.ShowInfo();


            User.Upgrade(firstSoftware, "2.0");
            firstSoftware.ShowInfo();
           //меняем статус
           User.StartWorkWithSoftware(firstSoftware);
            firstSoftware.ShowInfo();
            
            
            
        }
    }
}