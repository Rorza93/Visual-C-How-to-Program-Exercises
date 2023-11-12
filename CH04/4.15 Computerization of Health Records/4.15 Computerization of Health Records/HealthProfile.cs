// HealthProfile.cd
// A Health record contining user details, Average BMI's and target heart rate range and maximum heart rate

class HealthProfile
{ 
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Gender { get; set; }
    private int DayOfBirth { get; set; }
    private int MonthOfBirth { get; set; }
    private int YearOfBirth { get; set; }
    private decimal Height { get; set; }
    private decimal Weight { get; set; }

    public HealthProfile(string firstName, string lastName, string gender, int dayOfBirth, int monthOfBirth, int yearOfBirth, decimal height, decimal weight)
    {
        FirstName = firstName;
        LastName = lastName;
        Gender = gender;
        DayOfBirth = dayOfBirth;
        MonthOfBirth = monthOfBirth;
        YearOfBirth = yearOfBirth;
        Height = height;
        Weight = weight;
    }

    public void getHealthProfileInformation()
    {
        Console.WriteLine($"\nFirst Name: {FirstName}");
        Console.WriteLine($"Last Name: {LastName}");
        Console.WriteLine($"Gender: {Gender}");
        Console.WriteLine($"Date of Birth: {DayOfBirth}/{MonthOfBirth}/{YearOfBirth}");
        Console.WriteLine($"Height: {Height} CM's");
        Console.WriteLine($"Weight: {Weight} KG's");
        getAge();
        getAvergeHeartRate();
        getMaxHeartRate();
        getBMI();
    }

    public void getAge()
    { 
        int age = (DateTime.Now.Year - YearOfBirth);
        Console.WriteLine($"Age: {age}");
    }

    public void getMaxHeartRate()
    {
        int CurrentYear = DateTime.Now.Year;
        int age = (CurrentYear - YearOfBirth);
        int maxHeartRate = (220 - age);
        Console.WriteLine($"Max Heart Rate: {maxHeartRate}");
    }

    public void getAvergeHeartRate()
    {
        int CurrentYear = DateTime.Now.Year;
        int age = (CurrentYear - YearOfBirth);
        int maxHeartRate = (220 - age);

        // 50% of Max heart rate 
        double lowerAverageHeartRate = (maxHeartRate * 0.50);

        // 85% of Max Heart rate
        double upperAverageHeartRate = (maxHeartRate * 0.85);

        Console.WriteLine($"Target Heart Rate Between: {lowerAverageHeartRate} and {upperAverageHeartRate}");
    }

    public void getBMI()
    {
        decimal bmi = (Weight / (Height * Height) * 10000);
        Console.WriteLine($"BMI: {bmi}");
    }

}
