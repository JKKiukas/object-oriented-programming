using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_class
{
    class Truck : Car
    {
        protected int cargoWeight;
        protected double consumptionPerKg;

        public Truck()
        {
            cargoWeight = 0;
            consumptionPerKg = 0;
        }

        public Truck(string type, string brand, int year, double price, string engineSize, string model, int doorAmount, int cargoWeight, double consumptionPerKg):
            base(type, brand, year, price, engineSize, model, doorAmount)
        {
            this.cargoWeight = cargoWeight;
            this.consumptionPerKg = consumptionPerKg;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Kulkuvälineen lastin paino: {cargoWeight} Kg");
            Console.WriteLine($"Kulkuvälineen kulutus per Kg: {consumptionPerKg}");
        }

        public double CalculateConsumption()
        {
            double consumption = cargoWeight / consumptionPerKg;
            return consumption;
        }
    }
}
