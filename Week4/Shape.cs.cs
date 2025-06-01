using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4
{
    public abstract class Shape
    {
        public abstract double Area { get; }

        public void Display() {
            Console.WriteLine($"The area is: {Area}");
        }


    }
}
