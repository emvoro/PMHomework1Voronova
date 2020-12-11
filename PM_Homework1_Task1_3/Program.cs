using System;

namespace PM_Homework1_Task1_3
{
    class Program
    {
        static double RowSum()
        {
            double rowsum = 0;
            for (double i = 1; 1 / (i * (i + 1)) >= 1d / 2001d; i++)
            {
                rowsum += 1 / (i * (i + 1));
            }
            return rowsum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Task 1.3\nCalculation of row sum\nVoronova Emiliia\n");
            Console.WriteLine(" inf       1");
            Console.WriteLine(" SUM = ---------");
            Console.WriteLine("  1     i*(i+1)");
            Console.WriteLine("\nwhere 1/(i*(i+1)) >= epsilon");
            Console.WriteLine("epsilon = " + 1d / 2001d + "\n");
            Console.WriteLine("Result:");
            Console.WriteLine(RowSum());
            Console.ReadKey();
        }
    }
}

