using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_interfaceExample
{
    internal class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("The car is moving");
        }
        public void Stop()
        {
            Console.WriteLine("The car stopped");
        }
        
    }
}
