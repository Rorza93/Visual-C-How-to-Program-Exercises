// Account.cs
// A simple account Class that contains a private instance
// Variable name and public methods to Set and Get a name's value

class Account
{
    public string Name { get; set; } // auto-implemented property
    private decimal balance; // instance variable
    
    // Account constructor that receives two parameters 
    public Account(string accountName, decimal initialBalance) 
    { 
        Name = accountName;
        Balance = initialBalance; // Balance's set accessor validates
    }

    // Balance property with validation
    public decimal Balance
    { 
        get { return balance; }
        private set // can only be used within the class
        {
            // validate that the balance is greater than 0.0 if its not 
            // instance variable balance keeps its prior balance
            if (value > 0.0m) // m indicates that 0.0 is a decimal literal
            { 
                balance = value;
            }
        }
    }

    // method that deposit's (adds) only a valid amount to the balance
    public void Deposit(decimal depositAmount)
    {
        if (depositAmount > 0.0m) // if the depositAmount is valid
        {
            Balance = Balance + depositAmount; // add it to the balance
        }
    }

    // method that withdraws (removes) only a valid amount to the balance
    public void Withdraw(decimal depositAmount)
    {
        if (depositAmount > 0.0m) // if the depositAmount is valid
        {
            Balance = Balance - depositAmount; // add it to the balance
        }
    }

    // method to display account name and balance
    public void getAccountInformation()
    {
        Console.WriteLine($"{Name}'s balance: {Balance:C}");
    }
}

