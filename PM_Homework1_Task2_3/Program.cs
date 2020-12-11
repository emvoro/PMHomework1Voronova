using System;

namespace PM_Homework1_Task2_3
{
    public class Program
    {
        static void PrintArray(int[] array)
        {
            int[] sortedArray = BubbleSort(array);
            Console.Write("{ ");
            for (int i = 0; i < sortedArray.Length - 1; i++)
                Console.Write(sortedArray[i] + ", ");
            Console.Write(sortedArray[sortedArray.Length - 1] + " }\n");
        }

        static int[] BubbleSort(int[] array)
        {
            int temp;
            for (int j = 0; j <= array.Length - 2; j++)
            {
                for (int i = 0; i <= array.Length - 2; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        temp = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = temp;
                    }
                }
            }
            return array;
        }

        static int ElementsSum(int[] array)
        {
            int sum = 0;
            for(int i = 0; i < array.Length; i++)
                sum += array[i];
            return sum;
        }

        static double Average(int[] array)
        {
            return ElementsSum(array) / array.Length;
        }

        static double StandardDeviation(int[] array)
        {
            double result = 0;
            for (int i = 0; i < array.Length; i++)
                result += Math.Pow(array[i] - Average(array), 2);
            return Math.Sqrt(result / array.Length);
        }

        static void GetArrayStatistics(int[] array)
        {
            Console.WriteLine("\nSorted Array");
            Console.WriteLine("------------");
            PrintArray(array);
            Console.WriteLine("Minimal element    : " + BubbleSort(array)[0]);
            Console.WriteLine("Maximal element    : " + BubbleSort(array)[array.Length - 1]);
            Console.WriteLine("Sum of elements    : " + ElementsSum(array));
            Console.WriteLine("Average            : " + Average(array));
            Console.WriteLine("Standard Deviation : " + StandardDeviation(array));
        }

        static int Main(string[] args)
        {
            if (args != null && args.Length != 0)
            {
                string[] stringArray = args[0].Split( new char[] { ' ' });
                int[] array = new int[stringArray.Length];
                int i = 0;
                while (i < stringArray.Length)
                {
                    if (int.TryParse(stringArray[i], out array[i]))
                        i++;
                    else
                        return -1;
                }
                GetArrayStatistics(array);
                return 200;
            }
            else
            {
                Console.WriteLine("Task 2.3 Array Statistics\nVoronova Emiliia\nYou can enter array elements and get its statictics:\n" +
                    " - minimal element\n - maximal element\n - sum of elements\n - average of array\n - standard deviation");
                Console.WriteLine("\nEnter an array length :");
                int length;
                while (!int.TryParse(Console.ReadLine(), out length) || length <= 0)
                    Console.WriteLine("Length must be positive integer number.\nEnter an array length :");
                int[] array = new int[length];
                bool correctValues = false;
                for (int i = 0; i < length; i++)
                {
                    correctValues = true;
                    Console.WriteLine($"Enter the {i+1} element :");
                    if (!int.TryParse(Console.ReadLine(), out array[i]))
                        correctValues = false;
                    if (!correctValues)
                    {
                        Console.WriteLine($"An element must be an integer number.\n");
                        i--;
                    }
                }
                GetArrayStatistics(array);
                return 200;
            }
        }
    }
}
