using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_1
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Double Result;
            double Number1;
            double Number2;
            char Operator;
            Console.WriteLine("Enter the 1st Number:");
            string input_number1 = Console.ReadLine();
            bool parsedSuccesfully_number1 = double.TryParse(input_number1, out Number1);
            if (parsedSuccesfully_number1 == true)
            {
                Console.WriteLine("Enter the 2nd Number:");
                string input_number2 = Console.ReadLine();
                bool parsedSuccesfully_number2 = double.TryParse(input_number2, out Number2);
                if (parsedSuccesfully_number2 == true)
                {
                    Console.Write("Enter the operator (+, -, *, /):");
                    string input_operator = Console.ReadLine();
                    char.TryParse(input_operator, out Operator);
                    if (Operator == '+')
                    {
                        Result = Number1 + Number2;
                        Console.WriteLine($"Sum of { Number1} and { Number2} is { Result }");
                    }
                    else if (Operator == '-')
                    {
                        Result = Number1 - Number2;
                        Console.WriteLine($"Substraction of { Number1} and { Number2} is { Result }");
                    }
                    else if (Operator == '*')
                    {
                        Result = Number1 * Number2;
                        Console.WriteLine($"Multiplication of { Number1} by { Number2} is { Result }");
                    }
                    else if (Operator == '/')
                    {
                        Result = Number1 / Number2;
                        Console.WriteLine($"Division of { Number1} by { Number2} is { Result }");
                    }
                    else
                    {
                        Console.WriteLine("Unknown Operator");
                    }
                }
                else
                {
                    Console.WriteLine("Please make sure, that you've entered the mumber");
                }
            }
            else
            {
                Console.WriteLine("Please make sure, that you've entered the mumber");
            }
            Console.ReadKey();
        }
    }
}
