using Week2;

class Program
{
    static void Main(string[] args)
    {
        Person p1 = new Person("John", 30);
        Console.WriteLine($"Person Name and age: {p1.PersonName}, {p1.PersonAge}");

        Person p2 = new Person("John");
        Console.WriteLine($"Person Name and age: {p2.PersonName}, {p2.PersonAge}");
        p2.DisplayDetails();

        Employee e1 = new Employee("Josh", 29, "11001", "IT Departrment");
        e1.DisplayEmployeeDetails();
        e1.DisplayDetails();

        Employee e2 = new Employee("11002", "HR Departrment");
        e2.DisplayEmployeeDetails();

        Employee e3 = new Employee();
        e3.PersonName = "Mike";
        e3.PersonAge = 32;
        e3.EmpId = "11003";
        e3.Dep = "Management department";
        e3.DisplayEmployeeDetails();

        Manager m = new Manager("Emma", 35, "M001", "Management", 20);
        m.DisplayDetails();

        LibraryItem li = new LibraryItem("The Great Gatsby", "F. Scott Fitzgerald", 1925);
        li.DisplayDetails();

        Book b = new Book("The Great Gatsby", "F. Scott Fitzgerald", 1925, "978-0743273565", "literature");
        b.DisplayDetails();

        Magazine m1 = new Magazine("The Great Gatsby", "F. Scott Fitzgerald", 1925, 13, "Once in a Year");
        m1.DisplayDetails();


    }
}