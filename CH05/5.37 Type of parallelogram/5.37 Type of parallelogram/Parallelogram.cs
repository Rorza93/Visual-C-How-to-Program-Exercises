// Parallelogram.cs
// take 4 integers that are a valid parallelogram and determine their type
using System;

class Parallelogram
{
    public void GetParallelogramType(bool parrallelReturn, bool sidesReturn, bool angleReturn)
    {
        if (parrallelReturn)
        {
            if (sidesReturn && angleReturn)
            {
                Console.WriteLine("Your Parallelogram is a Square");
            }
            else if (sidesReturn && !angleReturn)
            {
                Console.WriteLine("Your Parallelogram is a Rhombus");
            }
            else
            {
                Console.WriteLine("Your Parallelogram is a Rectangle");
            }
        }
        else Console.WriteLine("You have not entered a valid parallelogram");
    }


    // Returns True if 4 internal angles equal 360
    public bool GetIsParallelogram(double angle1, double angle2, double angle3, double angle4)
    {
        double total = angle1 + angle2 + angle3 + angle4;
        if (total == 360)
            return true;
        return false;
    }
    
    // If SideCounter returns True the parallelogram is a square or Rhombus
    // If SideCounter returns False the parallelogram is a rectangle
    public bool GetSidesEqual(double side1, double side2, double side3, double side4)
    {
        int sideCounter = 1;
        if (side1 == side2)
            sideCounter++;
        if (side1 == side3)
            sideCounter++;
        if (side1 == side4)
            sideCounter++;
        if (sideCounter == 4)
        {
            return true;
        }

        return false;
    }

    // If AngleEqual returns True the parallelogram is either a Square or a Rectangle
    // If AngleEqual returns False the parallelogram is a Rhombus
    public bool GetAnglesEqual(double angle1, double angle2, double angle3, double angle4)
    {
        int angleCounter = 1;
        
        if (angle1 == angle2)
            angleCounter++;
        if (angle1 == angle3)
            angleCounter++;
        if (angle1 == angle4)
            angleCounter++;
        if (angleCounter == 4)
            return true;

        return false;
    }
    static void Main()
    {
        Parallelogram parallel1 = new Parallelogram();


        // Enter the sides of your Parallelogram here
        double side1 = 20;
        double side2 = 20;
        double side3 = 20;
        double side4 = 20;

        // Enter the internal angles of your parallelogram here
        double angle1 = 100;
        double angle2 = 100;
        double angle3 = 80;
        double angle4 = 80;


        bool parraReturn = parallel1.GetIsParallelogram(angle1, angle2, angle3, angle4);
        bool sideReturn = parallel1.GetSidesEqual(side1, side2, side3, side4);
        bool angleReturn = parallel1.GetAnglesEqual(angle1, angle2, angle3, angle4);

        parallel1.GetParallelogramType(parraReturn, sideReturn, angleReturn);
        

        

    }


}