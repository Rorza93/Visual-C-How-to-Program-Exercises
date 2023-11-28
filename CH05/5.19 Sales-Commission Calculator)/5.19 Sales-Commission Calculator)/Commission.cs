// Commission.cs
// app that inputs one salesperson’s items sold for the last week, then calculates and displays that salesperson's earnings

class Commission
{ 
    private int Item1Sold { set; get; }
    private int Item2Sold { set; get; }
    private int Item3Sold { set; get; }
    private int Item4Sold { set; get; }

    public Commission(int item1Sold, int item2Sold, int item3Sold, int item4Sold)
    {
        Item1Sold = item1Sold;
        Item2Sold = item2Sold;
        Item3Sold = item3Sold;
        Item4Sold = item4Sold;
    }

    public void GetCommission()
    {
        // Initializing variables
        decimal Item1Price = 239.99M; 
        decimal Item2Price = 129.75M;
        decimal Item3Price = 99.95M;
        decimal Item4Price = 350.89M;
        decimal StaffWage = 200M; 
        decimal ComissionPercentage = 0.09M; // 9% comission

        decimal Item1Comission = (Item1Sold * Item1Price * ComissionPercentage);
        decimal Item2Comission = (Item2Sold * Item2Price * ComissionPercentage);
        decimal Item3Comission = (Item3Sold * Item3Price * ComissionPercentage);
        decimal Item4Comission = (Item4Sold * Item4Price * ComissionPercentage);

        decimal Total = (StaffWage + Item1Comission + Item2Comission + Item3Comission + Item4Comission); 

        Console.WriteLine($"Your total wage earned this week is {Total:C}");

    }
}