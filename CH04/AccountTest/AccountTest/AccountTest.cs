// AccountTest.cs
// Creating and Manipulating Account Object

using System;
using System.Runtime.InteropServices;

class AccountTest
{
    static void Main()
    {
        // create two account objects
        Account account1 = new Account("Jane Greene", 1.10m);
        Account account2 = new Account("John Blue", 55000m);

        // Display initial balance of each object
        Console.WriteLine(
            $"{account1.Name}'s balance: {account1.Balance:C}");
        Console.WriteLine(
            $"{account2.Name}'s balance: {account2.Balance:C}");

        // Prompt for the read input
        Console.Write("\nEnter deposit amount for account1: ");
        decimal depositAmount = decimal.Parse( Console.ReadLine() );
        Console.WriteLine($"adding {depositAmount:C} to account1 balance\n");
        account1.Deposit( depositAmount ); // Add to account1's balance

        // Display balance of each object
        Console.WriteLine(
            $"{account1.Name}'s balance: {account1.Balance:C}");
        Console.WriteLine(
            $"{account2.Name}'s balance: {account2.Balance:C}");

        // prompt for then read input
        Console.Write("\nEnter withdraw amount for account2: ");
        depositAmount = decimal.Parse(Console.ReadLine());


        if (depositAmount < account2.Balance)
        {
            Console.WriteLine($"removing {depositAmount:C} to account2 balance\n");
            account2.Withdraw(depositAmount); // Remove from account2's balance
        }
        else 
        { Console.WriteLine($"\nWithdraw amount exceed's account balance!\nAccount Balance: {account2.Balance:C}\n"); 
        
        }

        

        // Display balance of account2
        Console.WriteLine(
            $"{account2.Name}'s balance: {account2.Balance:C}");

        Console.ReadLine();
    }
}