using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_interfaceExample
{
    internal class Rectangle : IShape
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double Area => width * height;
        public void Draw()
        {
            Console.WriteLine("Drawing a Rectangle");
        }
    }
}
