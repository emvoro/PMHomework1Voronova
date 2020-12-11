using System;

namespace PM_Homework1_Task2_2
{
    class Program
    {
        static double CircleSquare(double radius)
        {
            return Math.PI * radius * radius;
        }

        static double SquareSquare(double a)
        {
            return a * a;
        }

        static double RectangleSquare(double a, double b)
        {
            return a * b;
        }

        static double TriangleSquare(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        static int CalculateFigureSquare(string command)
        {
            double square = 0;
            string[] figure = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string figureName = figure[0];
            double radius = 0;
            double a = 0;
            double b = 0;
            double c = 0;
            bool flag = true;
            switch (figureName)
            {
                case "circle":
                    {
                        if (figure.Length > 2)
                        {
                            flag = false;
                            break;
                        }
                        else 
                        {
                            try
                            {
                                Double.TryParse(figure[1], out radius);
                            }
                            catch (Exception ex)
                            {
                                flag = false;
                                break;
                            }
                            finally
                            {
                                square = CircleSquare(radius);
                            }
                        }      
                        break;
                    }
                case "square":
                    {
                        if (figure.Length > 2)
                        {
                            flag = false;
                            break;
                        }
                        try
                        {
                            Double.TryParse(figure[1], out a);
                        }
                        catch (Exception ex)
                        {
                            flag = false;
                            break;
                        }
                        square = SquareSquare(a);
                        break;
                    }
                case "rect":
                    {
                        if (figure.Length > 3)
                        {
                            flag = false;
                            break;
                        }
                        try
                        {
                            Double.TryParse(figure[1], out a);
                            Double.TryParse(figure[2], out b);
                        }
                        catch (Exception ex)
                        {
                            flag = false;
                            break;
                        }
                        finally
                        {
                            square = RectangleSquare(a, b);
                        }
                        break;
                    }
                case "triangle":
                    {
                        if (figure.Length > 4)
                        {
                            flag = false;
                            break;
                        }
                        try
                        {
                            Double.TryParse(figure[1], out a);
                            Double.TryParse(figure[2], out b);
                            Double.TryParse(figure[3], out c);
                        }
                        catch (Exception ex)
                        {
                            flag = false;
                            break;
                        }
                        finally 
                        {
                            square = TriangleSquare(a, b, c);
                        }  
                        break;
                    }
                case "exit":
                    break;
                default:
                    flag = false;
                    break;
            }
            if (flag && square != 0 && command != "exit")
            {
                Console.WriteLine(square);
                return 200;
            }   
            else if(command != "exit")
                return -1;
            return -1;
        }


        static int Main(string[] args)
        {
            if (args != null && args.Length != 0)
            {
                string command = args[0];
                Console.WriteLine(CalculateFigureSquare(command) == -1 ? "-1" : "");
            }
            else
            {
                Console.WriteLine("Task 2.2 Figure square calculation\n Voronova Emiliia");
                Console.WriteLine("List of available commands:\n - circle {radius}\n - square {a}\n - rect {a} {b}" +
                    "\n - triangle {a} {b} {c}");
                string command = "";
                while (command != "exit")
                {
                    Console.WriteLine("\nEnter command :");
                    command = Console.ReadLine();
                    if(CalculateFigureSquare(command) == -1)
                        Console.WriteLine("Wrong input format!\nList of available commands:\n - circle {radius}\n - square {a}" +
                    "\n - rect {a} {b}\n - triangle {a} {b} {c}");
                }
            }
            return -1;
        }
    }
}
