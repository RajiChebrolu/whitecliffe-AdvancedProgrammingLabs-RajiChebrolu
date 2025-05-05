using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1
{
    internal class Student
    {
        public string Name;
        public string Grade;
        
        public Student(string name, string grade)
        {
            Name = name;
            Grade = grade;
        }

        public static void DisplayStudents(Student[] students)
        {
            Console.WriteLine("------Students List:--------");
            foreach (Student student in students)
            {
                Console.WriteLine($"Name: { student.Name}, Grade: { student.Grade}");
            }


        }
    }
}
