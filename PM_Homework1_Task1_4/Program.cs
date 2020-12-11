using System;

namespace PM_Homework1_Task1_4
{
    class Program
    {
        static bool IsPrime(int x)
        {
            if (x == 1)
                return false;
            for (int i = 2; i <= x / i; i++)
                if (x % i == 0)
                    return false;
            return true;
        }

        static void PrimeNumbersSearch(int left, int right)
        {
            for (int i = left; i <= right; i++)
            {
                if (IsPrime(i))
                {
                    Console.Write(i + " ");
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Task 1.4\nPrime numbers search\nVoronova Emiliia\n");
            Console.WriteLine("Enter search diapason using space in between:");
            string diapason = Console.ReadLine();
            string[] leftRight = diapason.Split(" ");
            int left = Convert.ToInt32(leftRight[0]);
            int right = Convert.ToInt32(leftRight[1]);
            Console.WriteLine($"\nPrime numbers in diapason {left} - {right}:");
            PrimeNumbersSearch(left, right);
            Console.ReadKey();
        }
    }
}
