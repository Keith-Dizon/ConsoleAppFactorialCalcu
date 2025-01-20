using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("--- Factorial Calculator ---");

        // input number
        Console.Write("Enter a non-negative integer: ");
        int number;

        // validate input to make sure it is a non negative
        while (!int.TryParse(Console.ReadLine(), out number) || number < 0)
        {
            Console.WriteLine("Invalid input. Please enter a non-negative integer.");
            Console.Write("Enter a non-negative integer: ");
        }

        // calculate
        long factorial = 1; // Use long to handle large numbers
        for (int i = 1; i <= number; i++)
        {
            factorial *= i;
        }

        // display the result
        Console.WriteLine($"The factorial of {number} is: {factorial}");
    }
}
