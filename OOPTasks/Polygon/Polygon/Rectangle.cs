using System;
using System.Collections.Generic;
using System.Text;

namespace Polygon
{
    class Rectangle : Shape
    {
        public double length;
        public double width;

        public Rectangle()
        {
            length = 0;
            width = 0;
        }

        public Rectangle(string type, string color, double length, double width)
            :base(type, color)
        {
            this.length = length;
            this.width = width;
        }

        public override double Area()
        {
            return length * width;
        }

        public override string GetInfo()
        {
            return $"Muoto: {type}" +
                   $"\nväri: {color}" +
                   $"\nSuorakulmion pituus: {length} cm" +
                   $"\nSuorakulmion leveys: {width} cm" +
                   $"\nSuorakulmion pinta-ala: {Area()} cm\n";
        }
    }
}
