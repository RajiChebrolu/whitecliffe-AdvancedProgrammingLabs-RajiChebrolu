using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4
{
    internal class SavingsAccount : Account
    {
        public override double CalculateInterest()
        {
            Console.WriteLine("Savings Account:");
            return 6.5;
        }
    }
}
