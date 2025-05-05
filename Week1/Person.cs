using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Week1
{
    internal class Person
    {
        public string firstName;
        public string lastName;
        public int age;
        public Person() 
        { 
            firstName = "Raji";
            lastName = "Chebrolu";
            age = 20;
        }
        public void DisplayPerson()
            {
                Console.WriteLine("---------Person Details:--------");
                Console.WriteLine("FirstName: " + firstName);
                Console.WriteLine("LastName:" + lastName);
                Console.WriteLine("Age:" + age);
            }

        

    }
}
