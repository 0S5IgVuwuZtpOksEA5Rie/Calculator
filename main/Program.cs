using System;

namespace main
{
    class Program
    {
        static void Main()
        {
            char[] validOperators = { '+', '-', '*', '/' };
            bool firstNumberUseArray = false;
            bool secondNumberUseArray = false;

            bool firstNumberNegative = false;
            bool secondNumberNegative = false;

            Console.Write("Enter first number: ");
            string firstNumberString = Console.ReadLine();

            // Use the smallest memory if possible, if not, keep going larger
            try
            {
                short firstNumber = Convert.ToInt16(firstNumberString);
            }
            catch (OverflowException)
            {
                try
                {
                    int firstNumber = Convert.ToInt32(firstNumberString);
                }
                catch (OverflowException)
                {
                    try
                    {
                        long firstNumber = Convert.ToInt64(firstNumberString);
                    }
                    catch (OverflowException)
                    {
                        // Since can not go larger with standard integer variable types, turn the large integer into a array
                        firstNumberUseArray = true;
                        short[] firstNumber = { };
                        // Note that it is negative and remove the negative sign
                        if (firstNumberString[0] == '-')
                        {
                            firstNumberNegative = true;
                            firstNumberString.Substring(1);
                        }
                        // Flip the integer around so one's place is at 0, ten's at 1...
                        for (short placeValue = 0; placeValue < firstNumberString.Length; placeValue++)
                        {
                            firstNumber[placeValue] = Convert.ToInt16(firstNumberString[(placeValue + 1) * -1]);
                        }
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Format exception, only insert integers");
            }

            bool invalidInput = true;
            while (invalidInput)
            {
                Console.Write("Enter operator (+ - * /): ");
                var @operator = Convert.ToChar(Console.ReadLine());
                if (@operator in validOperators)
                {
                    invalidInput = false;
                }
                else
                {
                    Console.WriteLine("Invalid input")
                }
            }


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