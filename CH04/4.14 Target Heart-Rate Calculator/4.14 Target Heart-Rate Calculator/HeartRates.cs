//HeartRates.cs
// This class is used to calculate maximum heart rate 

using System.Security.Cryptography.X509Certificates;

class HeartRates
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    private int BirthYear { get; set; }
    public int CurrentYear { get; set; }



    public HeartRates(string firstName, string lastName, int birthYear, int currentYear)
    {
        FirstName = firstName;
        LastName = lastName;
        BirthYear = birthYear;
        CurrentYear = currentYear;
    }

    public void getHeartRateInformation()
    {
        Console.WriteLine($"First Name: {FirstName}");
        Console.WriteLine($"Last Name: {LastName}");
        Console.WriteLine($"Birth Year: {BirthYear}");
        Console.WriteLine($"Current Year: {CurrentYear}");
    }

    public void getMaxHeartRate()
    {
        int age = (CurrentYear - BirthYear);
        int maxHeartRate = (220 - age);
        Console.WriteLine($"Your maximum heart rate is {maxHeartRate}");
    }

    public void getAvergeHeartRate()
    {
        int age = (CurrentYear - BirthYear);
        int maxHeartRate = (220 - age);

        // 50% of Max heart rate 
        double lowerAverageHeartRate = (maxHeartRate * 0.50);

        // 85% of Max Heart rate
        double upperAverageHeartRate = (maxHeartRate * 0.85);

        Console.WriteLine($"Your target heart rate is between {lowerAverageHeartRate} and {upperAverageHeartRate}");
    }
}
