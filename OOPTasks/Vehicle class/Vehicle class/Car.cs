using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_class
{
    class Car : Vehicle
    {
        protected string engineSize;
        protected string model;
        protected int doorAmount;

        public Car()
        {
            engineSize = null;
            model = null;
            doorAmount = 0;
        }

        public Car(string type, string brand, int year, double price, string engineSize, string model, int doorAmount):
            base(type, brand, year, price)
        {
            this.engineSize = engineSize;
            this.model = model;
            this.doorAmount = doorAmount;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Kulkuvälineen moottorin koko: {engineSize}");
            Console.WriteLine($"Kulkuvälineen malli: {model}");
            Console.WriteLine($"Kulkuvälineen ovien määrä: {doorAmount}");
        }

        public override string ToString()
        {
            return ($"\nKulkuvälineen tyyppi: {type}" +
                    $"\nKulkuvälineen merkki: {brand}" +
                    $"\nKulkuvälineen vuosimalli: {year}" +
                    $"\nKulkuvälineen hinta: {price}€" +
                    $"\nKulkuvälineen moottorin koko: {engineSize}" +
                    $"\nKulkuvälineen malli: {model}" +
                    $"\nKulkuvälineen ovien määrä: {doorAmount}");
        }

        public override bool Equals(object obj)
        {
            Car carObj = obj as Car;
            if(carObj == null)
            {
                return false;
            }
            else
            {
                return model.Equals(carObj.model);
            }
        }
    }
}
