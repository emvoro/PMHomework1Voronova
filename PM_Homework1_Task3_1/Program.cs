using System;

namespace PM_Homework1_Task3_1
{
    class Program
    {
        
        static double Addition(double a, double b)
        {
            return a + b;
        }

        static double Substraction(double a, double b)
        {
            return a - b;
        }

        static double Multiplication(double a, double b)
        {
            return a * b;
        }

        static double Division(double a, double b)
        {
            return a / b;
        }

        static double RemainderOfDivision(double a, double b)
        {
            return a % b;
        }

        static double Power(double a, int b)
        {
            return Math.Pow(a, b);
        }

        static int And(int a, int b)
        {
            return a & b;
        }

        static int Or(int a, int b)
        {
            return a | b;
        }

        static int NotOr(int a, int b)
        {
            return a ^ b;
        }

        static int Not(int a)
        {
            return ~a;
        }

        static int Factorial(int a)
        {
            if (a == 0)
                return 1;
            else
                return a * Factorial(a - 1);
        }

        static double EchoMode(double a)
        {
            return a;
        }

        static double EchoModeWithMinus(double a)
        {
            return -a;
        }

        static void Calculate()
        {
            Console.WriteLine("Enter your equation : ");
            string input = Console.ReadLine();
            double result = 0;
            bool isValid = true;
            
            string[] powerCheck = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            char[] operatorSearchArray = input.ToCharArray();
            char operation = ' ';
            int countSymbols = 0;
            for(int i = 0; i < operatorSearchArray.Length; i++)
            {
                if (operatorSearchArray[i] == '+' || operatorSearchArray[i] == '-' || operatorSearchArray[i] == '*' ||
                    operatorSearchArray[i] == 'x' || operatorSearchArray[i] == '/' || operatorSearchArray[i] == '\\' ||
                    operatorSearchArray[i] == '%' || operatorSearchArray[i] == '&' || operatorSearchArray[i] == '|' ||
                    operatorSearchArray[i] == '^' || operatorSearchArray[i] == '~' || operatorSearchArray[i] == '!')
                {
                    countSymbols++;
                    if (countSymbols == 1)
                    {
                        operation = operatorSearchArray[i];
                        operatorSearchArray[i] = ' ';
                    }
                    else 
                    { 
                        isValid = false;
                        Console.WriteLine("Error");
                        break;
                    }
                }
            }
            string withoutOperator = "";
            for (int i = 0; i < operatorSearchArray.Length; i++)
            {
                withoutOperator += operatorSearchArray[i];
            }
            string[] stringOperands = withoutOperator.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            double a = 0;
            double b = 0;

            if (!Double.TryParse(stringOperands[0], out a) || !Double.TryParse(stringOperands[1], out b))
            {
                Console.WriteLine("Incorrect data!");
            }
            else
            {
                if (powerCheck.Length > 1 && powerCheck[1] == "pow")
                    result = Power(a, (int)b);
                switch (operation)
                {
                    case '+':
                        result = Addition(a, b);
                        break;
                    case '-':
                        if (operatorSearchArray[0] == ' ')
                            result = EchoModeWithMinus(a);
                        else
                            result = Substraction(a, b);
                        break;
                    case '*':
                    case 'x':
                        result = Multiplication(a, b);
                        break;
                    case '/':
                    case '\\':
                        if (b == 0)
                        {
                            isValid = false;
                            Console.WriteLine("You can't divide by zero!");
                        }
                        else
                            result = Division(a, b);
                        break;
                    case '%':
                        result = RemainderOfDivision(a, b);
                        break;
                    case '&':
                        result = And((int)a, (int)b);
                        break;
                    case '|':
                        result = Or((int)a, (int)b);
                        break;
                    case '^':
                        result = NotOr((int)a, (int)b);
                        break;
                    case '!':
                        if (operatorSearchArray[0] == ' ')
                            result = Not((int)a);
                        else
                            result = Factorial((int)a);
                        break;
                    case ' ':
                        result = EchoMode(a);
                        break;
                    default:
                        break;
                }
                if(isValid)
                    Console.WriteLine(result + "\n");
            }
            Calculate();
        }

        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            if (args != null && args.Length > 0)
            { 
                
            }
            else
            {
                Calculate();
            }
        }
    }
}
