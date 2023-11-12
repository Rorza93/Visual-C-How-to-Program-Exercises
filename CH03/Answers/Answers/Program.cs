// Answers.cs

// Write an app that inputs three integers from the user
// and displays the sum, average, product, and smallest and largest of the numbers
// using System;

class Answers
{
    static void Main()
    {
        // First Value
        Console.Write("Enter first integer: ");
        int value1 = int.Parse(System.Console.ReadLine());

        // Second value
        Console.Write("Enter second integer: ");
        int value2 = int.Parse(System.Console.ReadLine());

        // Third value
        Console.Write("Enter final integer: ");
        int value3 = int.Parse(System.Console.ReadLine());

        // Sum
        int sum = (value1 + value2 + value3);
        Console.WriteLine("\nSUM");
        Console.WriteLine($"{value1} + {value2} + {value3} = {sum}");

        // Average
        int average = ((value1 + value2 + value3) / 3);
        Console.WriteLine("\nAVERAGE");
        Console.WriteLine($"The Average of {value1}, {value2} and {value3} is {average}");

        // Product
        int product = (value1 * value2 * value3);
        Console.WriteLine("\nPRODUCT");
        Console.WriteLine($"The Product of {value1}, {value2} and {value3} is {product}");

        // Smallest
        Console.WriteLine("\nSMALLEST");
        Console.Write("The Smallest number you have entered is ");
        if (value1 < value2 && value1 < value3)
            Console.WriteLine($"{value1}");
        if (value2 < value1 && value2 < value3)
            Console.WriteLine($"{value2}");
        if (value3 < value2 && value3 < value1)
            Console.WriteLine($"{value3}");

        // Largest
        Console.WriteLine("\nLARGEST");
        Console.Write("The Largest number you have entered is ");
        if (value1 > value2 && value1 > value3)
            Console.WriteLine($"{value1}");
        if (value2 > value1 && value2 > value3)
            Console.WriteLine($"{value2}");
        if (value3 > value2 && value3 > value1)
            Console.WriteLine($"{value3}");

    }   // End Main
}       // End Class Answers