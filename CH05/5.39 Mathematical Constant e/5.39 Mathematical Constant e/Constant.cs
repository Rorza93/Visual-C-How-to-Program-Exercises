// Constant.cs
// Used to get e(x)
using System;

class Constant
{
    public long GetFactorials(int number)
    {
        long factorial = 1;
        for (int i = 2; i <= number; i++)
        {
            factorial *= i;
        }
        return factorial;
    }

    public double GetEX()
    {
        double e = 1.0;
        for (int n = 1; n < 30; n++) 
        {
            e += 1.0 / GetFactorials(n);
        }
        return e;
    }
    
    static void Main()
    {
        Console.WriteLine(Math.E);
        Constant constant1 = new Constant();
        double GetE = constant1.GetEX();
        Console.WriteLine(GetE);
    }
}