using System;

class Program
{
    static void Main()
    {
        // Declare variables
        double num1, num2, average;

        // Get input from user
        Console.Write("Enter the first number: ");
        num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the second number: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        // Calculate the average
        average = (num1 + num2) / 2.0;

        // Print the average
        Console.WriteLine("The average of the two numbers is: " + average);

        // Check if the first number is greater than the average
        if (num1 > average)
        {
            Console.WriteLine("hello");
        }
        else
        {
            Console.WriteLine("buy");
        }
    }
}
