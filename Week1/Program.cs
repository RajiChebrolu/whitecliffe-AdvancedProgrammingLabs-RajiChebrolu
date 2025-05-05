using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Week1
{
    internal class Program

    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Make = "Hyundai Santa Fe";
            car1.Model = "Honda Civic/Civic Hybrid";
            car1.Year = 2025;
            car1.DisplayInfo();

            Car car2 = new Car("Hyundai", "Honda Hybrid", 2025);
            car2.DisplayInfo();
            car2.StartEngine();

            Book book = new Book();
            book.Title = "Invisible Emmie";
            book.Author = "Terri Libenson";
            book.Pages = 220;
            book.Read();

            Person person = new Person();
            person.DisplayPerson();

            Calculator cal = new Calculator();
            Console.WriteLine("---------Add NUmbers 2, 3, and 4--------");
            Console.WriteLine("Add 2 numbers:" + cal.add(2, 3));
            Console.WriteLine("Add 3 numbers:" + cal.add(4, 5, 6));
            Console.WriteLine("Add 4 numbers:" + cal.add(7, 8, 9, 10));


            Counter counter1 = new Counter();
            Counter counter2 = new Counter();
            Counter counter3 = new Counter();
            counter1.Increment();
            counter2.Increment();
            counter3.Increment();
            Console.WriteLine("---------Static Count--------");
            Console.WriteLine("Current count:" + Counter.GetCount());


            Student[] students = new Student[] {
                new Student("Raji", "A+"),
                new Student("John", "A"),
                new Student("Rachel", "B"),
                new Student("Cherry", "A+"),

            };

            Student.DisplayStudents(students);

        }

            
    }
}
