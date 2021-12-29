using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Laba_5
{
    public abstract class Inventar
    {
        public override string ToString() => GetType().Name;
        protected int money = 1000;
        public void MoneyPlus(int value)
        {
            if (value < 0) throw new Exeption2("Зачем в минус то уходить", value);
            if (value > 999999) throw new Exeption2("Слишком жирно...", value);

            Debug.Assert(value <= 999999, "Много");

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
            else throw new Exeption1("Недостаточно средств");
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
            else throw new Exeption1("Недостаточно средств");
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
            else throw new Exeption1("Недостаточно средств");
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

    ////////////////////////////////////////////////////////////////////////////////////////////////
    sealed class football : Ball,IBall
    {
        public enum Firma
        {
            nike,adidas,puma
        }
       public struct FFF
        {
            Firma name;
            int _price;


            public Firma Name
            {
                get => name;
                set => name = value;
            }
            public int Price
            {
                get => _price;
                set => _price= value;
            }
        }

        public FFF[] companies;

        public football()
        {
            companies = new FFF[3];
            companies[0].Name = Firma.adidas;
            companies[0].Price = 100;
            companies[1].Name = Firma.nike;
            companies[1].Price = 150;
            companies[2].Name = Firma.puma;
            companies[2].Price = 200;
        }




        void IBall.Print()
        {
            Console.WriteLine($"Использовал интерфейс:{ToString()}");
        }
        public override void Print()
        {
            Console.WriteLine($"Использовал абстрактный:{ToString()}");
        }
    }
}
