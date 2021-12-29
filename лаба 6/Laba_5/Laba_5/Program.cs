using System;

namespace Laba_5
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Bench bench = new Bench();
                Mats mats = new Mats();
                Bars bars = new Bars();
                bench.ShowMoney();
                bench.Buy();
                bench.Buy(2);
                //bench.Buy(1000);
                bench.MoneyPlus(1000);
                //bench.MoneyPlus(1000000000);
                Printer printer = new Printer();
                printer.IAmPrinting(bench);
                Basket basket = new Basket();
                IBall ibasket = new Basket();
                basket.Print();
                ibasket.Print();


                football ball = new football();
                foreach (var firma in ball.companies)
                {
                    Console.WriteLine($"Мяч {firma.Name} cтоит {firma.Price}");
                }


                Console.WriteLine();
                Gym<Inventar> gym = new Gym<Inventar>();
                gym.ShowPrice();
                gym.Add(bench, 2);
                gym.Add(mats);
                gym.Show();
                gym.ShowPrice();
                gym.Add(bars, 4);
                gym.Show();
                gym.Sort();
                gym.Show();
                Console.WriteLine("Введите диапазон цен(от х до y)");
                int x = int.Parse(Console.ReadLine());
                int y = int.Parse(Console.ReadLine());

                foreach(var elem in gym.list)
                {
                    if (elem.Price() > x && elem.Price() < y)
                    {
                        Console.Write("***"+elem+"***");
                    }
                }
                Console.WriteLine();
            }
            catch(Exeption1 ex)
            {
                LOG.WriteLog(ex);
                throw;
            }
            catch(Exeption2 ex)
            {
                LOG.WriteLog(ex);
            }
            finally
            {
                Console.WriteLine("\nEND");
            }
        }
    }
}
