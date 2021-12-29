using System;

namespace Laba_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Bench bench = new Bench();
            Mats mats = new Mats();
            Bars bars = new Bars();
            bench.ShowMoney();
            bench.Buy();
            bench.Buy(2);
            bench.MoneyPlus(1000);
            Printer printer = new Printer();
            printer.IAmPrinting(bench);
            Basket basket = new Basket();
            IBall ibasket = new Basket();
            basket.Print();
            ibasket.Print();


        }
    }
}
