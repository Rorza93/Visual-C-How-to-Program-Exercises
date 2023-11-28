// Largest.cs
// App used to determine the largest number out of 10 integers input

class Largest
{
    static void Main()
    {
        int largest = 0;
        int number = 0;
        for (int counter = 0; counter < 10; ++counter)
        {
            Console.Write("Enter an Interger value: ");
            number = int.Parse(Console.ReadLine());

            if (number > largest)
            { 
                largest = number;
            }
        }
        Console.WriteLine($"The largest integer entered was {largest}");
    }
}