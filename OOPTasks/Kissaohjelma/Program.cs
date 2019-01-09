using System;

namespace Kissaohjelma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tämä on kissaohjelma. \n");

            Cat myFirstCat = new Cat("Pilli", 1);
            myFirstCat.increaseWeight(1);
            myFirstCat.printWeight();

            Console.WriteLine("---------------------------------------- \n");

            Cat mySecondCat = new Cat("Pulla", 3);
            mySecondCat.increaseWeight(2);
            mySecondCat.printWeight();
        }
    }
}
