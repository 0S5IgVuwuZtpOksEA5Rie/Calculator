using System;

namespace main
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            var firstNumber = Convert.ToInt64(Console.ReadLine());

            Console.Write("Enter operator: ");
            var @operator = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter second number: ");
            var secondNumber = Convert.ToInt64(Console.ReadLine());

            double output;
            bool error = false;
            if (@operator == '+')
            {
                output = firstNumber + secondNumber;
            }
            else if (@operator == '-')
            {
                output = firstNumber - secondNumber;
            }
            else if (@operator == '*')
            {
                output = firstNumber * secondNumber;
            }
            else if (@operator == '/')
            {
                output = firstNumber / secondNumber;
            }
            else
            {
                error = true;
                output = 0;
            }

            if (error)
            {
                Console.WriteLine("Invalid operator");
            }
            else
            {
                Console.WriteLine(output);
            }
        }
    }
}