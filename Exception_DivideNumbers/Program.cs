using System;

class Exception_DivideNumbers
{
    static void DivideNumbers(int a, int b)
    {
        try
        {
            int result = a / b;
            Console.WriteLine(result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("A number cannot divide by zero.");
        }
    }

    static void ParseAndDivide(string num1, string num2)
    {
        try
        {
            int a = int.Parse(num1);
            int b = int.Parse(num2);
            int result = a / b;
            Console.WriteLine(result);
        }
        catch (FormatException)
        {
            Console.WriteLine("Input must be a valid integer.");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero.");
        }
    }

    static void DivideNumbers1(int a, int b)
    {
        try
        {
            int result = a / b;
            Console.WriteLine(result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("A number cannot divide by zero.");
        }
        finally
        {
            Console.WriteLine("Execution completed");
        }
    }

    static void SetTemperature(int temperature)
    {
        if (temperature < -50 || temperature > 50)
        {
            throw new InvalidTemperatureException("Temperature is out of the valid range");
        }
        else
        {
            Console.WriteLine($"Temperature set to {temperature} degrees.");
        }
    }

    static void OpenFile(string fileName)
    {
        try
        {
            using (FileStream fs = File.OpenRead(fileName))
            {
                Console.WriteLine("File Opened sucessfully.");
            }
        }
        catch (Exception ex)
        { Console.WriteLine(ex.Message); }
    }


    static void Main(string[] args)
    {
        DivideNumbers(10, 2);
        DivideNumbers(10, 0);
        Console.WriteLine("------------------------------");
        ParseAndDivide("10", "2");
        ParseAndDivide("abc", "2");
        ParseAndDivide("10", "0");
        Console.WriteLine("----------------------------");
        DivideNumbers1(10, 2);
        DivideNumbers1(10, 0);
        Console.WriteLine("----------------------------");
        try
        {
            SetTemperature(25);
            SetTemperature(-60);
        }
        catch (InvalidTemperatureException ex)
        {
            Console.WriteLine(ex.Message);
        }
        try
        {
            SetTemperature(60);
        }
        catch (InvalidTemperatureException ex)
        {
            Console.WriteLine(ex.Message);
        }
        Console.WriteLine("----------------------------");
        
        OpenFile("Students.txt");
        OpenFile("Tutors.txt");

    }
}
