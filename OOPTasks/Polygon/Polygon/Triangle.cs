using System;
using System.Collections.Generic;
using System.Text;

namespace Polygon
{
    class Triangle : Shape
    {
        public double length;
        public double width;

        public Triangle()
        {
            length = 0;
            width = 0;
        }

        public Triangle(string type, string color, double length, double width)
            :base(type, color)
        {
            this.length = length;
            this.width = width;
        }

        public override double Area()
        {
            return length * width / 2;
        }

        public override string GetInfo()
        {
            return $"Muoto: {type}"+
                   $"\nVäri: {color}"+
                   $"\nKolmion pituus: {length} cm" +
                   $"\nKolmion leveys: {width} cm" +
                   $"\nKolmion pinta-ala: {Area()} cm";
        }
    }
}
