using System;

class Expanded
{
    static void Main()
    {
        while (true)
        {
            int inputLength = 6;
            
            Console.Write("Enter a six-digit integer: ");
            string input = Console.ReadLine();

            if (input.Length != inputLength || !int.TryParse(input, out int number))
            {
                Console.WriteLine($"Error: The number must be exactly {inputLength} digits long.");
                continue;
            }

            string expandedForm = GetExpandedForm(number);
            Console.WriteLine($"Expanded form: {expandedForm}");
            break;
        }
    }

    private static string GetExpandedForm(int number)
    {
        string result = "";
        int place = 1;
        int baseNumber = 10; // base numbering system. we are using base 10

        while (number > 0)
        {
            int digit = number % baseNumber;
            number /= baseNumber;

            string part = $"{digit} x {place}";
            result = (digit != 0 ? part + (result != "" ? " + " : "") : "") + result;
            place *= baseNumber;
        }

        return result;
    }
}
