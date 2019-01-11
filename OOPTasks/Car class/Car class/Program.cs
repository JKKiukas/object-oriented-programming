using System;

namespace Car_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma pyytää käyttäjää syöttämään kaksi automerkkiä ja niiden nopeudet. Tämän jälkeen ohjelma tulostaa syötetyt tiedot. \n");
            Console.WriteLine("Syötä ensin autonmerkki ja sen nopeus. Tämän jälkeen tee sama uudelleen. \n");

            Car firstCar = new Car();
            Car secondCar = new Car();

            firstCar.AskData();
            secondCar.AskData();

            firstCar.ShowCarInfo();
            secondCar.ShowCarInfo();

            firstCar.Accelerate();
            secondCar.Accelerate();

            firstCar.Brake();
            secondCar.Brake();
        }
    }
}
