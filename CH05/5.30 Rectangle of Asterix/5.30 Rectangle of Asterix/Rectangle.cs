using System;

class Rectangle
{
    static void Main()
    {
        Console.WriteLine("This application will draw a rectangle for you out of asterisks!");

        int length = GetValidInput("Length of rectangle between 1 and 15: ", 1, 15);
        int width = GetValidInput("Width of rectangle between 1 and 10: ", 1, 10);

        DrawRectangle(length, width);
    }

    private static int GetValidInput(string prompt, int min, int max)
    {
        Console.Write(prompt);
        int input = int.Parse(Console.ReadLine());
        return Math.Clamp(input, min, max);
    }

    private static void DrawRectangle(int length, int width)
    {
        for (int w = 0; w < width; w++)
        {
            for (int l = 0; l < length; l++)
            {
                Console.Write('*');
            }
            Console.WriteLine();
        }
    }
}
