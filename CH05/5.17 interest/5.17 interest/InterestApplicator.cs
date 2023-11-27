/// <summary>
/// The InterestApplicator class is used to perform calculations combining total interest
/// using the initial investment amount and interest percentage.
/// </summary>
class InterestApplicator
{
    // Properties to store the value of the investment and the interest rate.
    private decimal Value { get; set; }
    private decimal Interest { get; set; }

    /// <summary>
    /// Initializes a new instance of the InterestApplicator class with specified value and interest.
    /// </summary>
    /// param name="value"The initial investment amount.</param> 
    /// param name="interest"The interest rate as a percentage.</param>
    public InterestApplicator(decimal value, decimal interest)
    {
        Value = value;
        Interest = interest;
    }

    /// <summary>
    /// Calculates and returns the total amount after applying interest.
    /// </summary>
    /// <returns>The total investment value after interest.</returns>
    public decimal GetTotal()
    {
        decimal total = Value + (Value * Interest);
        return total;
    }

    /// <summary>
    /// Calculates and returns the interest amount on the investment.
    /// </summary>
    /// <returns>The interest amount.</returns>
    public decimal GetInterest()
    {
        decimal interest = Value * Interest;
        return interest;
    }

    /// <summary>
    /// Sets the investment value.
    /// </summary>
    /// <param name="value">The investment value to be set.</param>
    public void SetValue(decimal value)
    {
        Value = value;
    }

    /// <summary>
    /// Sets the interest rate.
    /// </summary>
    /// <param name="interest">The interest rate as a percentage to be set.</param>
    public void SetInterest(decimal interest)
    {
        Interest = interest / 100;
    }

    /// <summary>
    /// Runs an interactive console session to calculate interest on an investment.
    /// Users can input investment values and interest rates, or use commands 'stop' to exit and 'help' for instructions.
    /// </summary>
    public void GetInterestApplicator()
    {
        string value = null;
        decimal initialInvestment = 0;
        decimal percentage = 0;
        decimal totalInterest = 0;
        decimal total = 0;

        while (true)
        {
            Console.Write("Please enter the value of your investment or type 'stop' to exit: ");
            value = Console.ReadLine();
            if (value == "stop")
            {
                break;
            }
            else if (value == "help")
            {
                Console.WriteLine("Enter your investments value and the percentage increase your investment will receive in one month.");
                Console.WriteLine("Or type 'stop' to show the results and exit the program.");
            }
            else
            {
                try
                {
                    initialInvestment = decimal.Parse(value);
                    SetValue(initialInvestment);

                    Console.Write("Please enter the interest percentage of your investment that it will gain in one month: ");
                    percentage = decimal.Parse(Console.ReadLine());
                    SetInterest(percentage);

                    totalInterest += GetInterest();
                    total += GetTotal();
                    Console.WriteLine($"\nCurrent total is : {total:C3}");
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Unable to parse '{value}'.");
                }
            }
        }

        // Display the final total interest and investment values
        Console.WriteLine($"\nYour total interest earned after 1 month will be {totalInterest:C3}");
        Console.WriteLine($"\nYour total investments after 1 month will be worth {total:C3}");
    }
}
