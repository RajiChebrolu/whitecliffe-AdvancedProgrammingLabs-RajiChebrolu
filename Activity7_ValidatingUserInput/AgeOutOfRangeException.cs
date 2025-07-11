using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity7_ValidatingUserInput
{
    public class AgeOutOfRangeException : Exception
    {
        public AgeOutOfRangeException(string message) : base(message) { }
    }
}
