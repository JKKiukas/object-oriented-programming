using System;
using System.Collections.Generic;

namespace Polygon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa tietoja monikulmioista.\n");

            Shape circle = new Circle("Ympyrä", "Sininen", 20);
            Shape rectangle = new Rectangle("Suorakulmio", "Vihreä", 30, 40);
            Shape triangle = new Triangle("Kolmio", "Punainen", 50, 60);

            List<Shape> shapeList = new List<Shape>
            {
                circle,
                rectangle,
                triangle
            };

            foreach(Shape shape in shapeList)
            {
                Console.WriteLine(shape.GetInfo());
            }

            Console.WriteLine(new string('-', 37));

            foreach(Shape shape in shapeList)
            {
                if(shape is Triangle)
                {
                    Console.WriteLine("Tulostetaan kolmion tiedot uudelleen.");
                    Console.WriteLine(new string('-', 37));
                    Console.WriteLine(shape.GetInfo());
                    Console.WriteLine();
                }
            }

        }
    }
}