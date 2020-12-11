﻿using System;
using System.Diagnostics;

namespace PM_Homework1_Task2_4
{
    class Program
    {
        static void StartMoreLessGame()
        {
            Console.WriteLine("Enter lower border :");
            int lowerBorder;
            while (!int.TryParse(Console.ReadLine(), out lowerBorder) || lowerBorder < 0 || lowerBorder > 1000000)
            {
                Console.WriteLine("Incorrect input. Input must be an integer number between 1 and 1 000 000.");
                Console.WriteLine("Enter lower border :");
            }
            Console.WriteLine("Enter upper border:");
            int upperBorder;
            while (!int.TryParse(Console.ReadLine(), out upperBorder) || upperBorder < 0 || upperBorder > 1000000)
            {
                Console.WriteLine("Incorrect input. Input must be an integer number between 1 and 1 000 000.");
                Console.WriteLine("Enter upper border :");
            }
            Random random = new Random();
            int numberToGuess = random.Next(lowerBorder, upperBorder + 1);
            Guess(numberToGuess, lowerBorder, upperBorder);
            Console.WriteLine();
        }

        static void Guess(int numberToGuess, int lowerBorder, int upperBorder)
        {
            int n = (int)Math.Round(Math.Log2(upperBorder - lowerBorder + 1));
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.WriteLine("\nGuess the number :");
            string command = "";
            int countTries = 0;
            int score = 0;
            while (command != "exit")
            {
                command = Console.ReadLine();
                if (command == "exit")
                {
                    score = 0;
                    break;
                }
                int guess;
                if (!int.TryParse(command, out guess) || guess < lowerBorder || guess > upperBorder)
                    Console.WriteLine("Incorrect input. Input must be an integer number between lower and upper border or an 'exit' command.");
                else
                {
                    if (guess > numberToGuess)
                    {
                        Console.WriteLine("Try less...");
                        countTries++;
                    }
                    else if (guess < numberToGuess)
                    {
                        Console.WriteLine("Try more...");
                        countTries++;
                    }
                    else
                    {
                        Console.WriteLine("You guessed the number correctly!");
                        score = 100 * (n - countTries) / n;
                        countTries++;
                        break;
                    }
                }
            }
            stopwatch.Stop();
            Console.WriteLine("\nStatistics");
            Console.WriteLine("----------");
            Console.WriteLine($"Score           : {score}");
            Console.WriteLine($"Number of tries : {countTries}");
            Console.WriteLine($"Game time       : {stopwatch.ElapsedMilliseconds / 1000} seconds");

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Task 2.1\nMore-Less Game\nVoronova Emiliia");
            Console.WriteLine("You can try to guess the number generated by the computer. Enter diapason and try yourself.\nTo leave the game enter the 'exit' command\n");
            Console.WriteLine("And let the force be with you!\n");
            StartMoreLessGame();
        }
    }
}