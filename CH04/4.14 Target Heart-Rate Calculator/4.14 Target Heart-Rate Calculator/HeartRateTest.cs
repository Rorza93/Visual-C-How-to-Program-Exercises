// HeartRateTest.cs
// This is used to test the Heart rate calcultor Class
using System;

class HeartRateTest
{
    static void Main()
    {
        Console.Write("First Name: ");
        string firstName = Console.ReadLine();
        Console.Write("Last Name: ");
        string lastName = Console.ReadLine();
        Console.Write("Birth Year: ");
        int birthYear = int.Parse(Console.ReadLine());
        int currentYear = DateTime.Now.Year;

        HeartRates Heart001 = new HeartRates(firstName, lastName,birthYear,currentYear);
        Heart001.getHeartRateInformation();
        Heart001.getMaxHeartRate();
        Heart001.getAvergeHeartRate();
    }
}