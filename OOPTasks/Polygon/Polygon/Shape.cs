using System;
using System.Collections.Generic;
using System.Text;

namespace Polygon
{
    abstract class Shape
    {
        public abstract double Area();

        public string type;
        public string color;

        public Shape()
        {
            type = string.Empty;
            color = string.Empty;
        }

        protected Shape(string type, string color)
        {
            this.type = type;
            this.color = color;
        }

        public virtual string GetInfo() { return null; }
    }
}
