using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity7_ValidatingUserInput
{
    public class NegativeAgeException : Exception
    {
        public NegativeAgeException(string message) : base(message) { }
    }
}
