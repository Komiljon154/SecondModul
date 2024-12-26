using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("------------------------\n");

            double num1 = 0; double num2 = 0; double result = 0;

            Console.WriteLine("Type a number, and then press Enter");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Type another number, and then press Enter");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.Write("Your option? ");

            switch (Console.ReadLine())
            {
                case "a":
                    result = num1 + num2;
                    Console.WriteLine($"Your result: {num1} + {num2} = " + result);
                    break;
                case "s":
                    result = num1 - num2;
                    Console.WriteLine($"Your result: {num1} - {num2} = " + result);
                    break;
                case "m":
                    result = num1 * num2;
                    Console.WriteLine($"Your result: {num1} * {num2} = " + result);
                    break;
                case "d":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine($"Your result: {num1} / {num2} = " + result);
                    }
                    else
                    {
                        Console.WriteLine("Cannot divide by zero.");
                    }
                    break;
                default:
                    Console.WriteLine("That is not a valid option.");
                    break;
            }

            Console.Write("Press any key to close the Calculator console app...");
            Console.ReadKey();
        }
    }
}