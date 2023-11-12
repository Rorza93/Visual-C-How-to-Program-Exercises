// IsEven.cs
// View whether or not an item is odd or even

using System;

class IsEven
{
    static void Main()
    {
        Console.Write("Enter integer: ");
        int value1 = int.Parse(Console.ReadLine());


        if (value1 % 2 == 0)
            Console.WriteLine("The value is even");
        else
            Console.WriteLine("The value is odd");
    }
}