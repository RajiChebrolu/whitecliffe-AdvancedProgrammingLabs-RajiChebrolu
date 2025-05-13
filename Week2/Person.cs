using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Week2
{
    public class Person
    {
        private string Name;
        private int Age;

        public string PersonName
        {
            get => Name;
            set => Name = value;
        }

        public int PersonAge
        {
            get => Age;
            set => Age = value;
        }

        public Person() { }
        public Person(string name, int age)
        {
            PersonName = name;
            PersonAge = age;
        }

        public Person(string name)
        {
            PersonName = name;
            PersonAge = 25;
        }
        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Person Name and Age Details: {PersonName}, {PersonAge}");
        }
    }
}
