using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4
{
    internal class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(double radius) { 
            Radius = radius;        
        }
        public override double Area => Math.PI* Radius * Radius;

    }
}
