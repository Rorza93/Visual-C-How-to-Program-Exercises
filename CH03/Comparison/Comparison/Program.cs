// Comparison.cs

using System;

class Comparison
{
    static void Main()
    {
        Console.Write("Enter first integer: ");
        int number1 = int.Parse(Console.ReadLine());

        Console.Write("Enter second integer: ");
        int number2 = int.Parse(Console.ReadLine());


        // Equal to
        if (number1 == number2)
                {
                    Console.WriteLine($"{number1} is equal to {number2}");
                }

        // Not equal to
        if (number1 != number2)
        {
            Console.WriteLine($"{number1} is not equal to {number2}");
        }

        // Greater than
        if (number1 > number2)
        {
            Console.WriteLine($"{number1} is greater than {number2}");
        }

        // Less than
        if (number1 < number2)
        {
            Console.WriteLine($"{number1} is less than {number2}");
        }

        // Geater than or equal to
        if (number1 >= number2)
        {
            Console.WriteLine($"{number1} is greater than or equal to {number2}");
        }


        // Less than or equal to
        if (number1 <= number2)
        {
            Console.WriteLine($"{number1} is less than or equal to {number2}");
        }
    }   // End Main
}       // End Class Comparison