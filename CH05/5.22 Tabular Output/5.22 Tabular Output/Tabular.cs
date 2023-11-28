// Tabular.cs
// Used to display a tabular input of values with the n, n^2, n^3 and (n^2 + n^3)
using System;

class Tabular
{
    static void Main()
    {
        Console.WriteLine($"{"n",-10}{"n^2",-10}{"n^3",-10}{"n^2 + n^3",-10}\n");
        for (int N = 10; N <= 50; N += 10)
        {
            int N2 = N * N;
            int N3 = N * N * N;
            int N2SumN3 = N2 + N3;
            Console.WriteLine($"{N,-10}{N2,-10}{N3,-10}{N2SumN3,-10}");
        }
    }
}