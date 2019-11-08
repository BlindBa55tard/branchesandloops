using System;

namespace NumbersInCSharp
{
    class Program
    {
        static void WorkingWithIntegers()
        {
            int a = 18;
            int b = 6;
            
            // addition
            int c = a + b;
            Console.WriteLine(c);
            
            // subtraction
            c = a - b;
            Console.WriteLine(c);
            
            // multiplication
            c = a * b;
            Console.WriteLine(c);
            
            // division
            c = a / b;
            Console.WriteLine(c);
        }

        static void OrderPredence()

        {


    

        double e = 19;
        double f = 23;
        double g = 8;
        double h = (e + f) /g;
        Console.WriteLine(h);

      
        double third = 1.0 / 3.0;
        Console.WriteLine(third);

        decimal min = decimal.MinValue;
        decimal max = decimal.MaxValue;
        Console.WriteLine($"The range of decimal is: {min} to {max}");
        
        double a = 1.0;
        double b = 3.0;
        Console.WriteLine(a / b);

        decimal c = 1.0M;
        decimal d = 3.0M;
        Console.WriteLine(c / d);
        
        double radius = 2.50;
        double area = Math.PI * radius * radius;
        Console.WriteLine(area);

        }
        static void Main(string[] args)
        {
            WorkingWithIntegers();

            OrderPredence();
        }
    }
}