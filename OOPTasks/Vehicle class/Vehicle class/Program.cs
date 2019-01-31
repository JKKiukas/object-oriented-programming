using System;

namespace Vehicle_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa tietoja Kulkuvälineistä.");
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Car car = new Car("Farmariauto", "Toyota", 2002, 3000, "1500 cm³", "Corolla", 5);
            Car secondCar = new Car("Urheiluauto", "Ferrari", 2018, 400000, "2200 cm³", "488GTB", 2);
            Truck truck = new Truck("Rekka-auto", "Sisu", 2006, 20000, "4000 cm³", "Polar", 2, 10000, 20);

            Console.WriteLine(car.ToString());
            Console.WriteLine(secondCar.ToString());

            Console.Write("------------------------------------------");

            if (car.Equals(secondCar))
            {
                Console.WriteLine("\nAutot ovat samoja.\n");
            }
            else
            {
                Console.WriteLine("\nAutot eivät ole samoja.");
            }

            Console.Write("------------------------------------------\n");
                         
            truck.PrintInfo();
            Console.WriteLine($"Kulkuvälineen kulutus L/100 Km: {truck.CalculateConsumption()} L");
        }
    }
}
