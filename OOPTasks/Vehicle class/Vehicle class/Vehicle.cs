using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_class
{
    abstract class Vehicle
    {
        protected string type;
        protected string brand;
        protected int year;
        protected double price;

        public Vehicle()
        {
            type = null;
            brand = null;
            year = 0;
            price = 0.00;
        }

        public Vehicle(string type, string brand, int year, double price)
        {
            this.type = type;
            this.brand = brand;
            this.year = year;
            this.price = price;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Kulkuvälineen tyyppi: {type}");
            Console.WriteLine($"Kulkuvälineen merkki: {brand}");
            Console.WriteLine($"Kulkuvälineen vuosimalli: {year}");
            Console.WriteLine($"Kulkuvälineen hinta: {price}€");
        }
    }
}
