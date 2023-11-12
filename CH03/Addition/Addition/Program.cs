// addition.cd
// This adds two numbers togeher and then displays the result

using System;

class Addition
{
    static void Main()
    {
        int number1;
        int number2;
        int sum;

        Console.Write("Enter your first number: ");
        // User enters the first part of their sum
        number1 = int.Parse(Console.ReadLine());

        Console.Write("Enter your second number: ");
        // User enters their second sum
        number2 = int.Parse(Console.ReadLine());

        // Add the summed numbers together
        sum = number1 + number2;


        // Display the sum to the user
        Console.WriteLine($"The sum of {number1} and {number2} is {sum}");

    }
}