using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_interfaceExample
{
    internal class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("The Bicycle is Moving");
        }
        public void Stop()
        {
            Console.WriteLine("The Bicycle stopped");
        }
    }
}
