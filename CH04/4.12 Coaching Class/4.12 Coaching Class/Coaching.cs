// Coaching.cs
// Class to display 4 properties 

class Coaching
{ 
    public string CoachingType { get; set; }
    public int PlayerNumber { get; set; }
    private string ClassTimings { get; set; }
    private decimal Charges { get; set; }


    // Coaching constructor to initialise four properties
    public Coaching(string coachingType, int playerNumber, string classTimings, decimal charges)
    { 
        CoachingType = coachingType;
        PlayerNumber = playerNumber;
        ClassTimings = classTimings;
        Charges = charges;
    }

    // Method to pring Coaching information
    public void getCoachingInformation()
    {
        Console.Write($"Coaching: {CoachingType} \t");
        Console.Write($"Number of Participants: {PlayerNumber} \t");
        Console.Write($"Class Times: {ClassTimings} \t");
        Console.Write($"Cost of Session: {Charges:C}");
    }
}