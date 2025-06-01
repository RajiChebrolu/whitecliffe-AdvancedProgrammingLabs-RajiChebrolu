using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4
{
    internal class WashingMachine : Appliance
    {
        public override void Operate()
        {
            Console.WriteLine("Washing clothes");
        }
    }
}
