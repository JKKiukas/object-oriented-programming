using System;
using System.Collections.Generic;
using System.Text;

namespace Kissaohjelma
{
    class Cat
    {
        public string name;
        public int weight;

        public Cat()
        {
            this.weight = 1;
        }

        public Cat(string name, int weightValue)
        {
            this.name = name;
            this.weight = weightValue;
            Console.WriteLine($"Luotu kissa {this.name}, jonka paino on {this.weight} Kg.");
        }

        public Cat(int weightValue)
        {
            this.weight = weightValue;
        }

        public void increaseWeight(int value)
        {
            this.weight += value;
            Console.WriteLine($"Kissan {this.name} uusi paino on {this.weight} Kg. \n");
        }

        public void printWeight()
        {
        }
    }
}
