// CountingNegativePositive.cs
//App that inputs five numbers and
//determines and displays the number of negative numbers input, the number of positive numbers
//input and the number of zeros input.

using System;

class CountingNegativePositive
{
    static void Main()
    {
        int positiveNumber = 0;
        int zeroNumber = 0;
        int negativeNumber = 0;

        Console.WriteLine("Please Enter 5 numbers");
        Console.Write("Enter number 1: ");
        int firstNumber = int.Parse(Console.ReadLine());
        if (firstNumber < 0)
            negativeNumber += 1;
        if (firstNumber > 0)
            positiveNumber += 1;
        if (firstNumber == 0)
            zeroNumber += 1;

        Console.Write("Enter number 2: ");
        int secondNumber = int.Parse(Console.ReadLine());
        if (secondNumber < 0)
            negativeNumber += 1;
        if (secondNumber > 0)
            positiveNumber += 1;
        if (secondNumber == 0)
            zeroNumber += 1;

        Console.Write("Enter number 3: ");
        int thirdNumber = int.Parse(Console.ReadLine());
        if (thirdNumber < 0)
            negativeNumber += 1;
        if (thirdNumber > 0)
            positiveNumber += 1;
        if (thirdNumber == 0)
            zeroNumber += 1;

        Console.Write("Enter number 4: ");
        int fourthNumber = int.Parse(Console.ReadLine());
        if (fourthNumber < 0)
            negativeNumber += 1;
        if (fourthNumber > 0)
            positiveNumber += 1;
        if (fourthNumber == 0)
            zeroNumber += 1;

        Console.Write("Enter number 5: ");
        int fifthNumber = int.Parse(Console.ReadLine());
        if (fifthNumber < 0)
            negativeNumber += 1;
        if (fifthNumber > 0)
            positiveNumber += 1;
        if (fifthNumber == 0)
            zeroNumber += 1;

        Console.WriteLine($"Positive numbers : {positiveNumber}\nNegative numbers : {negativeNumber}\nNumber of zeroes : {zeroNumber}");
    }
}