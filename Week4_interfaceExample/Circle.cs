using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_interfaceExample
{
    internal class Circle : IShape
    {
        private double radius;

        public Circle(double radius)
            { this.radius = radius; }
        public double Area => Math.PI * radius * radius;
        public void Draw()
        {
            Console.WriteLine("Drawing a circle");
        }
    }
}
