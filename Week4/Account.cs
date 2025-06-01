using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4
{
    public abstract class Account
    {
        public abstract double CalculateInterest();
        public void DisplayAccountInfo()
        {
            Console.WriteLine($"Interest: {CalculateInterest()}");
        }
    }
}
