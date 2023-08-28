using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Calculator");

            double num1 = GetValidNumber("Entere the first value");

            double num2 = GetValidNumber("Entere the second value");

            ShowMenu();

            int choice = GetValidChoice();


            double result = PerformOperation(choice, num1, num2);

            Console.WriteLine($"Result: {result}");

            Console.WriteLine("Press any key to exit.");
        }

        private static double div(double num1, double num2)
        {
            if (num2 != 0)
            {
                return num1 / num2;
            }
            else
            {
                return -1;
            }
        }

        private static double mult(double num1, double num2)
        {
            return num1 * num2;
        }

        private static double sub(double num1, double num2)
        {
            return num1 - num2;
        }

        private static double add(double num1, double num2)
        {
            return num1 + num2;
        }

        private static void ShowMenu()
        {
            Console.WriteLine("Select an operation:");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.WriteLine("5. Power");
        }

        private static double PerformOperation(int choice, double num1, double num2)
        {
            switch (choice)
            {
                case 1:
                    return add(num1, num2);
                case 2:
                    return sub(num1, num2);
                case 3:
                    return mult(num1, num2);
                case 4:
                    return div(num1, num2);
                case 5:
                    return Math.Pow(num1, num2);
                default:
                    Console.WriteLine("Invalid choice!");
                    return 0;
            }
        }

        static double GetValidNumber(string message)
        {
            double number;
            bool isValidInput = false;

            do
            {
                Console.WriteLine(message);
                if (double.TryParse(Console.ReadLine(), out number))
                {
                    isValidInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }
            } while (!isValidInput);

            return number;
        }

        static int GetValidChoice()
        {
            int choice;
            bool isValidInput = false;

            do
            {
                Console.Write("Enter your choice (1-5): ");
                if (int.TryParse(Console.ReadLine(), out choice) && choice >= 1 && choice <= 5)
                {
                    isValidInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid choice.");
                }
            } while (!isValidInput);
            return choice;
        }
    }
}
