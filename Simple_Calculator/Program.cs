using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Calculator");

            double num1, num2;
            bool isValidInput = false;

            do
            {
                Console.Write("Enter the first value: ");
                if (double.TryParse(Console.ReadLine(), out num1))
                {
                    isValidInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            } while (!isValidInput);

            isValidInput = false;

            do
            {
                Console.Write("Enter the second value: ");
                if (double.TryParse(Console.ReadLine(), out num2))
                {
                    isValidInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            } while (!isValidInput);

            Console.WriteLine("Select an operation:");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.WriteLine("5. Power");

            int choice;
            do
            {
                Console.Write("Enter your choice (1-5): ");
                if (int.TryParse(Console.ReadLine(), out choice) && choice >= 1 && choice <= 5)
                {
                    isValidInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                }
            } while (!isValidInput);

            double result = 0;

            switch (choice)
            {
                case 1:
                    result = add(num1,num2);
                    break;
                case 2:
                    result = sub(num1,num2);
                    break;
                case 3:
                    result = mult(num1,num2);
                    break;
                case 4:
                    result = div(num1,num2);
                    break;
                case 5:
                    result = Math.Pow(num1, num2);
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }

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
    }
}
