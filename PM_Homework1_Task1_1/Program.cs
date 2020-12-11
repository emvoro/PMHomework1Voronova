using System;

namespace PM_Homework1_Task1_1
{
    class Program
    {
        static double ExpressionCalculation(double a, int b, int c, int d)
        {
            return (Math.Exp(a) + 4 * Math.Log(c, 10)) / Math.Sqrt(b) * Math.Abs(Math.Atan(d)) + (5 / Math.Sin(a));
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Task 1.1\nExpression Calculation\nVoronova Emiliia\n");
            Console.WriteLine("Expression will be calculated using the following formula :\n");
            Console.WriteLine(" y = e^a + 4 * lg(c) * |arctg(d)| +   5  ");
            Console.WriteLine("     ---------------                -----");
            Console.WriteLine("         sqrt(b)                    sin(a)");
            Console.WriteLine("\nwhere b = 2001,\n      c = 3,\n      d = 19\n");
            Console.WriteLine("Enter parameter a : ");
            double a = double.Parse(Console.ReadLine());
            const int b = 2001;
            const int c = 3;
            const int d = 19;
            Console.WriteLine("\nResult : ");
            Console.WriteLine("\ny = " + ExpressionCalculation(a, b, c, d));
            Console.ReadKey();
        }
    }
}

