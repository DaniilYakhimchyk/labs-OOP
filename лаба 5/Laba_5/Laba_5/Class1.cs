using System;
using System.Collections.Generic;
using System.Text;

namespace Laba_5
{
    public abstract class Inventar
    {
        public override string ToString() => GetType().Name;
        protected int money = 1000;
        public void MoneyPlus(int value)
        {
            money += value;
            Console.WriteLine($"После довабления у вас {money}$");
        }
        public void ShowMoney()
        {

            Console.WriteLine($"У вас {money}$");
        }
        public abstract int Price();
        public abstract void Buy(int amount=1);

    }


    class Bench:Inventar  //скамейка
    {
        private int cost = 100;
        public override int Price() => cost;
        public override void Buy(int amount=1)
        {
            if (money >= amount * cost)
            {
                money -= amount * cost;
                Console.WriteLine($"---------После покупки {amount} скамейки за {cost}--------"); ShowMoney();

            }
            else Console.WriteLine("Не хватает денег");
        }
        
    }
    class Bars:Inventar
    {
        private int cost = 250;
        public override int Price() => cost;
        public override void Buy(int amount = 1)
        {
            if (money >= amount * cost)
            {
                money -= amount * cost;
                Console.WriteLine($"---------После покупки {amount} брусьев за {cost}--------"); ShowMoney();

            }
            else Console.WriteLine("Не хватает денег");
        }
    }
    class Mats:Inventar
    {
        private int cost = 300;
        public override int Price() => cost;
        public override void Buy(int amount = 1)
        {
            if (money >= amount * cost)
            {
                money -= amount * cost;
                Console.WriteLine($"---------После покупки  {amount} мата за {cost}--------"); ShowMoney();

            }
            else Console.WriteLine("Не хватает денег");
        }
    }


    public abstract class Ball
    {
        public override string ToString() => GetType().Name;
        public abstract void Print();
     

    }
    sealed class Basket:Ball,IBall
    {
        public override void Print()
        {
            Console.WriteLine($"Использовал абстрактный:{ToString()}");
        }
        
        void IBall.Print()
        {
            Console.WriteLine($"Использовал интерфейс:{ToString()}");
        }
    }
    class Printer
    {
        public void IAmPrinting(Inventar obj)
        {
            Console.WriteLine($"Тип: {obj.ToString()}");
        }
        public void IAmPrinting(Ball obj)
        {
            Console.WriteLine($"Тип: {obj.ToString()}");
        }
    }



}
