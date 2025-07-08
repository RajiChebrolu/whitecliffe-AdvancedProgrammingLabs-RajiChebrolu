namespace UnitTestingLab
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Hello World!");
        }

        virtual public int Addition(int a, int b)
            { return a + b; }

        virtual public int Subtraction(int a, int b) { return a - b; }

        virtual public double Division(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException("Cannot divide a number by zero.");
            return (double)a / b;
        }

        public virtual long Factorial(int a)
        {
            if (a < 0)
                throw new ArgumentException("Negative number inputs are not allowed.");
            if (a == 0 || a == 1)
                return 1;

            long result = 1;
            for (int i = 2; i <= a; i++)
            {
                result *=i;
            }
            return result;
        }
    }
}