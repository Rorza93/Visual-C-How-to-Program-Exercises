using System;

class Expanded
{
    static void Main()
    {
        Console.Write("Enter the binary number you would like to convert: ");
        string input = Console.ReadLine();
        
        int length = input.Length;
        int total = 0;
        int positionalValue = 1;
        while (length > 0)
        {
            int current = int.Parse(input[length - 1].ToString());
            total = total + positionalValue * current;
            positionalValue *= 2;
            length--;
            
        }
        Console.WriteLine($"Binary: {input} \nBase 10: {total} ");
    }
}