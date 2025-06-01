using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4
{
    internal class CheckingAccount : Account
    {
        public override double CalculateInterest()
        {
            Console.WriteLine("Checking Account:");
            return 8.5;
        }
    }
}
