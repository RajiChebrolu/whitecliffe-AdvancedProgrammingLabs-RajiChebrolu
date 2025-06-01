namespace Week4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Motorcycle motorcycle = new Motorcycle();
            car.StartEngine();
            car.StopEngine();
            motorcycle.StartEngine();
            motorcycle.StopEngine();

            Circle c1 = new Circle(10);
            Console.WriteLine("-----------------------");
            Console.WriteLine("Circle:");
            c1.Display();

            Rectangle r1 = new Rectangle(5, 10);
            Console.WriteLine("-----------------------");
            Console.WriteLine("Rectangle:");
            r1.Display();

            Appliance[] appliances = new Appliance[]
            {
                new WashingMachine(),
                new Refrigerator()
            };
            Console.WriteLine("-----------------------");

            foreach (Appliance a in appliances)
            {
                
                a.Operate();
            }

            Console.WriteLine("-----------------------");
            SavingsAccount s1 = new SavingsAccount();
            s1.DisplayAccountInfo();

            CheckingAccount ca1 = new CheckingAccount();
            ca1.DisplayAccountInfo();


        }
    }
}
