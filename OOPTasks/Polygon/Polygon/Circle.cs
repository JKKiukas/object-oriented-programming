using System;
using System.Collections.Generic;
using System.Text;

namespace Polygon
{
    class Circle : Shape
    {
        public double radius;

        public Circle()
        {
            radius = 0;
        }

        public Circle(string type, string color, double radius)
            :base(type, color)
        {
            this.radius = radius;
        }

        public override double Area()
        {
            return radius * this.radius * Math.PI;
        }

        public override string GetInfo()
        {
            return $"Muoto: {type}" +
                   $"\nVäri: {color}" +
                   $"\nYmpyrän säde: {radius} cm" +
                   $"\nYmpyrän pinta-ala: {Area():F2} cm\n";
        }
    }
}
