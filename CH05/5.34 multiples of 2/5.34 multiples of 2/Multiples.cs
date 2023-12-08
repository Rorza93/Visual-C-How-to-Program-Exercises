// Multiples.cs
// Display the power of 2 40 times
using System;

class Multiples
{
    static void Main()
    {
        int multiple = 2;  // To display correctly change int to long

        for (int counter = 0; counter < 40; counter++)
        {
            Console.Write($"{(counter + 1)} ");
            Console.WriteLine(multiple);
            multiple *= 2;
        }
    }
}