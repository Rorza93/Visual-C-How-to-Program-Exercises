// Increment.cs
// Prefix increment and postfix increment operator
using System;

class Increment
{
    static void Main()
    {
        // demonstrate postfix increment operator
        int c = 5; //assign 5 to c
        Console.WriteLine($"c before postincrement: {c}"); // displays 5
        Console.WriteLine($"postincrementing c: {c++}"); // displays 5
        Console.WriteLine($"c after posctincrement: {c}"); // displays 6
        Console.WriteLine(); // skips a line

        // demonstrate prefix increment operator
        c = 5; //assign 5 to c
        Console.WriteLine($"c before preincrement: {c}"); // displays 5
        Console.WriteLine($"preincrementing c: {++c}"); // displays 6
        Console.WriteLine($"c after pretincrement: {c}"); // displays 6
    }
}