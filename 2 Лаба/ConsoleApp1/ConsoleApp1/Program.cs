using System;

namespace ConsoleApp1
{
    public partial class pHONE
    {
        public override bool Equals(Object obj)
        {
            if (obj == null)
                return false;
            pHONE car = obj as pHONE;
            if (car == null)
                return false;
            return car.id == this.id;
        }

        public override int GetHashCode()
        {
            if (this.id == -1)
                return 0;
            else
                return id % 10;
        }

        public override string ToString()
        {
            return $"ID: {this.id}\n" +
                $"ФИО: {this.fio}\n" +
                $"Адрес: {this.address}\n" +
                $"Номер карточки: {this.number}\n" +
                $"Дебет: {this.debit}\n" +
                $"Кредит: {this.credit}$\n" +
                $"Время городских разговоров: {this.time1}\n" +
                $"Время междугородных разговоров: {this.time2}\n";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            pHONE[] phone = new pHONE[5];
            phone[0] = new pHONE(12345, "POK", "qwert", 445481216, 183636826, 123456654, 83, 49);
            phone[1] = new pHONE(12345, "POK", "qwert", 445481216, 183636826, 123456654, 83, 49);
            phone[2] = new pHONE(12346, "PAK", "qwvrt", 445481217, 183636827, 123456655, 44, 48);
            phone[3] = new pHONE(12347, "PQK", "qwerq", 445481218, 183636828, 123456656, 55, 0);
            phone[4] = new pHONE(12348, "PZK", "qplkt", 445481219, 183636829, 123456657, 76, 0);
            Console.WriteLine($"Баланс на текущий момент {phone[4].Count} клиента: {phone[4].Balans()}");




            Console.WriteLine("Введите время межгородских разговоров: ");
            int x = Int32.Parse(Console.ReadLine());
            foreach (var ph in phone)
            {
                if (x < ph.Time1) ph.Print();

            }



            Console.WriteLine("Введите время не межгородских разговоров: ");
            int y = Int32.Parse(Console.ReadLine());
            foreach (var ph in phone)
            {
                if (0 < ph.Time2) ph.Print();

            }
           
                int xq = 10;
                int yq = 15;
                Addition(ref x, y); // вызов метода
                Console.WriteLine(x);   // 25

                Console.ReadLine();
            
            // параметр x передается по ссылке
            static void Addition(ref int x, int y)
            {
                x += y;
            }
        }
    }
}
    

    

