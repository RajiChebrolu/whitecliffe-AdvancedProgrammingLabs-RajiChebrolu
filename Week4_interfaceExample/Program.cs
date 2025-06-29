using System;
namespace Week4_interfaceExample
{
    interface IMovable
    {
        void Move();
        void Stop();
    }

    interface IShape
    {
        double Area { get; }
        void Draw();
    }

    interface IWorker
    {
        void PerformWork();
    }

    interface ILeader
    {
        void LeadTeam();
        void MakeReports();
    }
    class Program
    {
        static void Main(string[] args) {
            IMovable car1 = new Car();
            car1.Move();
            car1.Stop();
            Console.WriteLine("-------------------------------");
            IMovable b1 = new Bicycle();
            b1.Move();
            b1.Stop();
            Console.WriteLine("-------------------------------");
            IShape circle1 = new Circle(3);
            circle1.Draw();
            Console.WriteLine($"Area of a Circle is: {circle1.Area}");
            Console.WriteLine("-------------------------------");
            IShape r1 = new Rectangle(2, 3);
            r1.Draw();
            Console.WriteLine($"Area of a rectangle is: {r1.Area}");
            Console.WriteLine("-------------------------------");
            IWorker pm1 = new ProjectManage();
            pm1.PerformWork();
            ILeader pm2 = new ProjectManage();
            pm2.LeadTeam();
            pm2.MakeReports();
            Console.WriteLine("-------------------------------");
        }
    }
}
