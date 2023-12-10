// Factorals.cs
// Enter a non negative integer and get its factoral
using System;

class Factorials
{
    public int GetFactorials(int number)
    {
        int factorial = 1;
        for (int i = 2; i <= number; i++)
        {
            factorial *= i;
        }
        return factorial;
    }

    static void Main()
    {
        Console.Write("Please enter an integer: ");
        int factorial = int.Parse(Console.ReadLine());
        Factorials factorial1 = new Factorials();
        int factorialReturn = factorial1.GetFactorials(factorial);
        Console.WriteLine(factorialReturn);
    }
}