
using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
           
                Car[] cars = new Car[5];
                cars[0] = new Car(1317777, "BMW", "M4C", 2020, "Red", 125000, "6531-3");
                cars[1] = new Car(1317777, "BMW", "M4C", 2020, "Red", 125000, "6531-3");
                cars[2] = new Car(131344, "Porche", "Taycan", 2017, "White", 140000, "3215-12");
                cars[3] = new Car(1317723, "Audi", "RS6", 2016, "Silver", 100000, "8672-5");
                cars[4] = new Car(131771, "Renault", "Duster", 2013, "Red", 15000, "M948-23F");
                
                Console.Write("\n Введите марку автомобиля:");
                string inMark = Console.ReadLine(); ;
                foreach (Car car in cars)
                {
                    if (car.Brand == inMark)
                        car.Print();
                    
                }


            Console.WriteLine($"-----------\nВозраст 1й машины :{cars[0].AgeOfCar()} ");




                if (cars[0].Equals(cars[2]))
                    Console.WriteLine("\nЭти машины идентичны!\n");

                Console.Write("Введите количество лет эксплуатации: ");
                int year = Int32.Parse(Console.ReadLine());
                Console.WriteLine("\tСписок машин:");
                foreach (var car in cars)
                {
                    if (2021 - car.Year >= year)
                    {
                        car.Print();
                    }
                }

                Console.WriteLine("---------------------Цена---------------------");
                Car renoDuster = cars[4];
                int price = renoDuster.Price;
                renoDuster.Print();
                Console.WriteLine("Повышаем цену на 23%...");
                renoDuster.IncreasePrice(ref price, 23);
                renoDuster.Price = price;
                renoDuster.Print();
                Console.WriteLine("Теперь уменьшаем на 10%...");
                renoDuster.DecresePrice(ref price);
                renoDuster.Price = price;
                renoDuster.Print();
                Console.WriteLine("Меняем модель машины...");
                string model;
                renoDuster.ChangeModel(out model, "Arkana");
                renoDuster.Model = model;
                renoDuster.Print();

                renoDuster.ShowCount();

                var user = new { Name = "Даниил", Surname = "Яхимчик" };
                Console.WriteLine("Анонимный тип\n" +
                    $"Имя: {user.Name}\n" +
                    $"Фамилия: {user.Surname}\n");

                Console.WriteLine("Пример ошибки.");
                Car errorCar = new Car();
                errorCar.Id = 10000000;
           
          
        }
    }
}