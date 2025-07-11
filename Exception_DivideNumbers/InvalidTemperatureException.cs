using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class InvalidTemperatureException : Exception
    {
        public InvalidTemperatureException(string message) : base(message) { }
    }

