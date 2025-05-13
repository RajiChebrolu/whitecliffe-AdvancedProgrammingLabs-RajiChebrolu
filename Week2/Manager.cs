using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2
{
    internal class Manager : Employee
    {
        public int TeamSize;

        public Manager(string name, int age, string empId, string dep, int teamSize): base (name, age, empId, dep)
        {
            TeamSize = teamSize;
        }

        public Manager() :base (){ }
    }
}
