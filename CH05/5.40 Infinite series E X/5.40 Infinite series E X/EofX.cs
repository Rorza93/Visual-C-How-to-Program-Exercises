// Constant.cs
// Used to get e(x)
using System;

class Constant
{
    public double GetPower(int x, int n)
    {
        double total = 1.0;
        for (; n > 0; n--)
        {
            total *= x;
        }
        return total;
    }
    public long GetFactorials(int number)
    {
        long factorial = 1;
        for (int i = 2; i <= number; i++)
        {
            factorial *= i;
        }
        return factorial;
    }

    public double GetEX(int x)
    {
        double e = 1.0;
        for (int n = 1; n <= 20; n++)
        {
            e += (GetPower(x,n) / GetFactorials(n));
        }
        return e;
    }

    static void Main()
    {
        Console.WriteLine($"{Math.Pow(Math.E, 2)}");
        Constant constant1 = new Constant();
        int x = 2;
        double GetE = constant1.GetEX(x);
        Console.WriteLine(GetE);
        
    }
}