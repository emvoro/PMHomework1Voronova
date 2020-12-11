using System;

namespace PM_Homework1_Task1_2
{
    class Program
    {
        static double CalculationOfMargin(double W1, double X, double W2)
        {
            return 1 - 1 / (1 / W1 + 1 / X + 1 / W2);
        }

        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            Console.WriteLine("Task 1.2\nCalculation of margin\nVoronova Emiliia\n");
            Console.WriteLine("Participants :");
            Console.WriteLine("Enter Participant 1 :");
            string participant1 = Console.ReadLine();
            Console.WriteLine("Enter Participant 2 :");
            string participant2 = Console.ReadLine();
            Console.WriteLine("\nCoefficients :");
            Console.WriteLine("Enter coefficient W1 :");
            double W1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter coefficient X :");
            double X = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter coefficient W2 :");
            double W2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nResults :");
            Console.WriteLine($"\nWin {participant1} : " + Math.Round((1 / W1) * 100 / (1 / W1 + 1 / X + 1 / W2), 1, MidpointRounding.AwayFromZero) + "%");
            Console.WriteLine($"Win {participant2} : " + Math.Round((1 / W2) * 100 / (1 / W1 + 1 / X + 1 / W2), 1, MidpointRounding.AwayFromZero) + "%");
            Console.WriteLine($"Draw : " + Math.Round((1 / X) * 100 / (1 / W1 + 1 / X + 1 / W2), 1, MidpointRounding.AwayFromZero) + "%");
            Console.WriteLine($"Bookmaker's margin : {Math.Round(CalculationOfMargin(W1, X, W2) * 100, 1)}%");
            Console.ReadKey();
        }
    }
}

