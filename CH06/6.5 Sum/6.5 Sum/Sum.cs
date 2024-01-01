// Fig 6.5 Sum.cs
// Summing integers with the for statement
using System;

class Sum
{
    static void Main()
    {
        int total = 0; // inititalize total

        // total even integers 2 through 20
        for (int number = 2; number <= 20; number += 2)
        { 
            total += number;
        }
        Console.WriteLine($"Sum is {total}"); // display results
    }
}