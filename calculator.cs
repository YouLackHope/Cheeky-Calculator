using System;

namespace DannyPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 0;
            double num2 = 0;
            double result = 0;

            Console.WriteLine("-----------");
            Console.WriteLine("Calculator");
            Console.WriteLine("-----------");

            Console.Write("Enter number 1: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter number 2: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter an Option: +, -, *, /");



            switch (Console.ReadLine())
            {
                case "+":
                    result = num1 + num2;
                    Console.Write($"The result of: {num1} + {num2}  = " + result);
                    break;
                case "-":
                    result = num1 - num2;
                    Console.Write($"The result of: {num1} - {num2}  = " + result);
                    break;
                case "*":
                    result = num1 * num2;
                    Console.Write($"The result of: {num1} * {num2}  = " + result);
                    break;
                case "/":
                    result = num1 / num2;
                    Console.Write($"The result of: {num1} / {num2}  = " + result);
                    break;
                default:
                    Console.WriteLine("That wasnt a valid option");
                    break;
            }

            Console.ReadKey();
        }
    }
}
