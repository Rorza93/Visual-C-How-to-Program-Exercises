// HealthProfileTest.cs
// Used to test HelthProfile class

using System;
using System.Reflection;

class HealthProfileTest
{
    static void Main()
    {
        Console.Write("Enter First Name: ");
        string FirstName = Console.ReadLine();
        Console.Write("Enter Last Name: ");
        string LastName = Console.ReadLine();
        Console.Write("Enter Gender: ");
        string Gender = Console.ReadLine();
        Console.WriteLine("Enter Date of Birth");
        Console.Write("DD: ");
        int DayOfBirth = int.Parse(Console.ReadLine());
        Console.Write("MM: ");
        int MonthOfBirth = int.Parse(Console.ReadLine());
        Console.Write("YYYY: ");
        int YearOfBirth = int.Parse(Console.ReadLine());
        Console.Write("Enter Height in CM's: ");
        decimal Height = int.Parse(Console.ReadLine());
        Console.Write("Enter Weight in KG's: ");
        decimal Weight = int.Parse(Console.ReadLine());

        HealthProfile User001 = new HealthProfile(FirstName,LastName,Gender,DayOfBirth,MonthOfBirth,YearOfBirth,Height,Weight);
        User001.getHealthProfileInformation();
    }
}