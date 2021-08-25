using System;

namespace Multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Program to multiply three numbers
            Console.WriteLine("===== PROGRAM TO MULTIPLY THREE NUMBERS =====");
            // Declare variables
            int firstNumber;
            int secondNumber;
            int thirdNumber;
            int result;

            // Prompt use to enter first number
            Console.Write("Please enter the first number: ");
            firstNumber = int.Parse(Console.ReadLine());

            // Prompt use to enter second number
            Console.Write("Please enter the second number: ");
            secondNumber = int.Parse(Console.ReadLine());

            // Prompt use to enter third number
            Console.Write("Please enter the third number: ");
            thirdNumber= int.Parse(Console.ReadLine());

            // Multiply the numbers
            result = firstNumber * secondNumber * thirdNumber;

            // Display result
            Console.WriteLine("The product of " + firstNumber + " * " + secondNumber + " * " + thirdNumber + " is: " + result);
        }
    }
}
