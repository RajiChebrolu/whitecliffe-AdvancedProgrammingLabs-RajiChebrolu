using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2
{
    public class Employee : Person
    {
        protected string EmployeeId;
        protected string Department;

        public string EmpId
        {
            get => EmployeeId;
            set => EmployeeId = value;
        }

        public string Dep
        {
            get => Department;
            set => Department = value;
        }
        public Employee() : base() { }

        public Employee (string name, int age, string empId, string dep) : base(name, age)
        {            
            EmpId = empId;
            Dep = dep;            
        }
            
        public Employee (string empId, string dep) : base ("Alex", 27)
        {
            EmpId = empId;
            Dep = dep;

        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"Employee {PersonName}, and his age {PersonAge} working in {Dep} with EmployeeID {EmpId}");
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Person Name, Age Details: {PersonName}, {PersonAge}, Working in {Dep} and Employee ID is {EmpId}");
        }
    }
}
