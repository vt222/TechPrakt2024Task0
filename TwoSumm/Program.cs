using System;

namespace SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables to store the numbers
            int number1, number2, sum;

            // Request user input for the first number
            Console.WriteLine("Enter the first number:");
            number1 = Convert.ToInt32(Console.ReadLine());

            // Request user input for the second number
            Console.WriteLine("Enter the second number:");
            number2 = Convert.ToInt32(Console.ReadLine());

            // Calculate the sum of the two numbers
            sum = number1 + number2;

            // Display the sum to the user
            Console.WriteLine("The sum of " + number1 + " and " + number2 + " is " + sum + ".");

            // Wait for the user to acknowledge the result before closing
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
