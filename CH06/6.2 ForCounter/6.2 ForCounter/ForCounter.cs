// Fig 6.2 ForCounter.cs
// Counter-Controlled iteration with the for iteration statement
using System;

class ForCounter
{
    static void Main()
    {
        // for statements header contains initialization
        // loop-continuation condition and increment
        for (int counter = 1; counter <= 10; ++counter)
        { 
            Console.Write($"{counter} ");
        }
        Console.WriteLine();
    }
}