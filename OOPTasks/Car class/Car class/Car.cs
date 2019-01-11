using System;
using System.Collections.Generic;
using System.Text;

namespace Car_class
{
    class Car
    {
        public string brand;
        public double speed;

        public Car()
        {
        }

        public Car(string brand, int speed)
        {
            this.brand = brand;
            this.speed = speed;
        }
        
        public void AskData()
        {
            Console.Write("Syötä auton merkki: ");
            string userInput = Console.ReadLine();
            this.brand = userInput;

            Console.Write($"Syötä auton {this.brand} nopeus: ");
            string userInput2 = Console.ReadLine();

            if (!string.IsNullOrEmpty(userInput2))
            {
                this.speed = int.Parse(userInput2);
            }
            else
            {
                Console.WriteLine($"\nEt syöttänyt autolle {this.brand} nopeutta, joten sen nopeus on 0 Km/h.");
            }
        }

        public void ShowCarInfo()
        {
            Console.WriteLine($"\nAuton merkki on {this.brand} ja sen nopeus on {this.speed} Km/h.");
        }

        public void Accelerate()
        {
            Console.Write($"\nSyötä auton {this.brand} kiihtyvyys: ");
            int speed2 = 0;
            string userInput2 = Console.ReadLine();

            if (userInput2.Length > 0)
            {
                speed2 = int.Parse(userInput2);
            }

            if (speed2 > 0)
            {
                this.speed += speed2;
            }
            else
                Console.WriteLine($"\nEt kiihdyttänyt auton {this.brand} nopeutta, joten sen nopeus pysyy nopeudessa {this.speed} Km/h.");

            if (speed2 < 0)
            {
                Console.WriteLine("Kiihtyvyys ei voi olla negatiivinen luku.");
            }
            else
                Console.WriteLine($"\nAuton {this.brand} nopeus on {this.speed} Km/h.");
        }

        public void Brake()
        {
            this.speed = speed * 0.9;
            Console.WriteLine($"\nAuto {this.brand} hidasti nopeutta 10% jarruttaessaan ja sen nopeus on nyt {this.speed} Km/h.");
        }
    }
}
