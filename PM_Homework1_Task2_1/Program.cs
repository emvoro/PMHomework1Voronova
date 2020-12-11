using System;
using System.Collections.Generic;

namespace PM_Homework1_Task2_1
{
    class Program
    {
        static List<string> UserCommands = new List<string>();
        static List<string> ComputerCommands = new List<string>();
        static List<string> Results = new List<string>();
        static int CountWins = 0;
        static int CountDraws = 0;
        static int CountLosses = 0;

        static void StartRockScissorsPaperGame()
        {
            Console.ForegroundColor = ConsoleColor.White;
            string[] actions = { "rock", "scissors", "paper" };
            Console.WriteLine("Enter your command :");
            string userAction = Console.ReadLine();
            Random random = new Random();
            int computerAction = Convert.ToInt32(random.Next(0, 3));
            string resultMessage = "";
            switch (userAction)
            {
                case "rock":
                    UserCommands.Add(userAction);
                    ComputerCommands.Add(actions[computerAction]);
                    switch (computerAction)
                    {
                        case 0:
                            resultMessage = "Draw";
                            CountDraws++;
                            break;
                        case 1:
                            resultMessage = "Win";
                            CountWins++;
                            break;
                        case 2:
                            resultMessage = "Loss";
                            CountLosses++;
                            break;
                    }
                    Results.Add(resultMessage);
                    ShowGameResult(userAction, actions[computerAction], resultMessage);
                    StartRockScissorsPaperGame();
                    break;
                case "scissors":
                    UserCommands.Add(userAction);
                    ComputerCommands.Add(actions[computerAction]);
                    switch (computerAction)
                    {
                        case 0:
                            resultMessage = "Loss";
                            CountLosses++;
                            break;
                        case 1:
                            resultMessage = "Draw";
                            CountDraws++;
                            break;
                        case 2:
                            resultMessage = "Win";
                            CountWins++;
                            break;
                    }
                    Results.Add(resultMessage);
                    ShowGameResult(userAction, actions[computerAction], resultMessage);
                    StartRockScissorsPaperGame();
                    break;
                case "paper":
                    UserCommands.Add(userAction);
                    ComputerCommands.Add(actions[computerAction]);
                    switch (computerAction)
                    {
                        case 0:
                            resultMessage = "Win";
                            CountWins++;
                            break;
                        case 1:
                            resultMessage = "Loss";
                            CountLosses++;
                            break;
                        case 2:
                            resultMessage = "Draw";
                            CountDraws++;
                            break;
                    }
                    Results.Add(resultMessage);
                    ShowGameResult(userAction, actions[computerAction], resultMessage);
                    StartRockScissorsPaperGame();
                    break;
                case "exit":
                    Console.WriteLine("\nStatistics :\n");
                    Console.WriteLine($"Count of games : {ComputerCommands.Count}\n");
                    for (int i = 0; i < Results.Count; i++)
                        Console.WriteLine($"Game {i + 1} : {Results[i]}");
                    Console.WriteLine($"\nWins   : {CountWins}\nDraws  : {CountDraws}\nLosses : {CountLosses}\n");
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Incorrect input!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("List of available commands:\n\n rock\n scissors\n paper\n exit\n");
                    StartRockScissorsPaperGame();
                    break;
            }
        }

        static void ShowGameResult(string userAction, string computerAction, string resultMessage)
        {
            Console.WriteLine($"Your command     : {userAction}");
            Console.WriteLine($"Computer command : {computerAction}");
            if (resultMessage == "Win")
                Console.ForegroundColor = ConsoleColor.Green;
            else if (resultMessage == "Draw")
                Console.ForegroundColor = ConsoleColor.Yellow;
            else
                Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(resultMessage + "\n");
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Task 2.1\nRock, Scissors, Paper\nVoronova Emiliia");
            Console.WriteLine("Rules :\nYou can play the game with computer.\nEnter your command and get the result immediately.");
            Console.WriteLine("List of available commands:\n\n rock\n scissors\n paper\n exit\n");
            Console.WriteLine("rock WINS scissors\nscissors WIN paper\npaper WINS rock\n");
            StartRockScissorsPaperGame();
        }
    }
}