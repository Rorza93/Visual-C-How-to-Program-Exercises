// Quadrilateral.cs
// Take 4 integer angles and determine if the object is a valid quadrilateral
using System;
using System.Reflection.Metadata;

class Quadrilateral
{
    static void Main()
    {
        int counter = 1;
        int side1 = 90;
        int side2 = 90;
        int side3 = 90;
        int angle1 = 90;

        if (side1 == side2)
            counter++;
        if (side1 == side3)
            counter++;
        if (side1 == side4)
            counter++;

        if (counter == 4)
        {
            Console.WriteLine("Your Quad is a square");
        }
        else if (counter == 2)
        { 
            Console.WriteLine("Your Quad is a rectangle");
        }
        else
            Console.WriteLine();
    }
}

  