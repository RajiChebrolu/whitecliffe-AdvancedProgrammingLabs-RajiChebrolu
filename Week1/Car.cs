using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1
{
    //Exercise 1: Basic Class Car
    internal class Car
    {
        public string Make;
        public string Model;
        public int Year;

        public Car()
        {

        }

        //Constructor
        public Car(string make, string model, int year)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }

        // A method to display the details of the Car
        public void DisplayInfo()
        {
            Console.WriteLine("---------Car Info:--------");
            Console.WriteLine("Make:" + Make);
            Console.WriteLine("Model:" + Model);
            Console.WriteLine("Year:" + Year);
        }

        public void StartEngine()
        {
            Console.WriteLine("---------Car Engine Info:--------");
            Console.WriteLine("Engine started");
        }
    }
        

}
