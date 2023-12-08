// Asterix.cs
// Application to draw asterix pattern
using System;
using System.Diagnostics.Metrics;

class Asterix
{
    static void Main()
    {
        string asterix = "*";
        string space = " ";

        for (int counter = 0; counter < 8; counter++)
        {
            if (counter % 2 == 0)
            {
                for (int counter2 = 0; counter2 < 8; counter2++)
                {
                    Console.Write($"{asterix}{space}");
                }
                Console.WriteLine();
            }
            else
            {
                for (int counter3 = 0; counter3 < 8; counter3++)
                {
                    Console.Write($"{space}{asterix}");
                }
                Console.WriteLine();
            }
        }
    }
}
