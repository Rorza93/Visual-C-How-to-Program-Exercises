// Dangling.cs
using System;

class Dangling
{
    static void Main()
    {
        int x = 6; int y = 5;

        if (x > 5)
        {
            if (y > 5)
            Console.WriteLine("x and y are > 5");
        }
        else
        {
            Console.WriteLine("x is <= 5");
        }
                
    }
}