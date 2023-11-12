using System;

namespace DigitsSeparator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a 5-digit number:");
            string input = Console.ReadLine();

            foreach (char digit in input)
            {
                Console.Write(digit + "   "); // Three spaces between digits
            }

            Console.ReadLine(); // To keep the console window open
        }
    }
}
