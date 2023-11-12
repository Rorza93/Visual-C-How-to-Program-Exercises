// AccountTest.cs
// Creating and Manipulating Account Object

using System;

class AccountTest
{
    static void Main()
    {
        // create two account objects
        Account account1 = new Account("Jane Greene", 1.10m);
        Account account2 = new Account("John Blue", 55000m);

        // Display initial balance of each object
        account1.getAccountInformation();
        account2.getAccountInformation();

        // Prompt for the read input
        Console.Write($"\nEnter deposit amount for {account1.Name}'s Account: ");
        decimal depositAmount = decimal.Parse( Console.ReadLine() );
        Console.WriteLine($"adding {depositAmount:C} to {account1}'s balance\n");
        account1.Deposit( depositAmount ); // Add to account1's balance

        // Display balance of each object
        account1.getAccountInformation();
        account2.getAccountInformation();

        // prompt for then read input
        Console.Write($"\nEnter withdraw amount for {account2.Name}'s account: ");
        depositAmount = decimal.Parse(Console.ReadLine());


        if (depositAmount < account2.Balance)
        {
            Console.WriteLine($"removing {depositAmount:C} to {account2.Name}'s balance\n");
            account2.Withdraw(depositAmount); // Remove from account2's balance
        }
        else 
        { Console.WriteLine($"\nWithdraw amount exceed's account balance!\nAccount Balance: {account2.Balance:C}\n"); 
        
        }


        // Display balance of account2
        account2.getAccountInformation();

    }
}