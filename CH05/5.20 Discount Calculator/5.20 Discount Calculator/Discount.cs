// Discount.cd
//determine the net amount payable for items purchased at a departmental store.
using System;
using System.Xml.Schema;

class Discount
{
    public decimal GetItems()
    {
        decimal Total = 0M;
        decimal value = 0M;
        Console.WriteLine("Please enter the value of all items purchased one by one to determine the discount you will receive.");
        do
        {
            Console.Write("Enter the value of your item or enter the value as 0 once you are done: ");
            value = decimal.Parse(Console.ReadLine());
            Total = Total + value;
            
        }
        while (value != 0);

        return Total;
    }

    public void GetDiscount(decimal total)
    {
        decimal SmallDiscountPercentage = 10; // 10% discount
        decimal LargeDiscountPercentage = 20; // 20% discount
        decimal smallDiscount = 1.00M - (SmallDiscountPercentage / 100); // Updates the percentage to work as an equasion
        decimal largeDiscount = 1.00M - (LargeDiscountPercentage / 100); // Updates the percentage to work as an equasion

        if (total <= 5000)
        { 
            decimal NetValue = total * smallDiscount;
            Console.WriteLine($"Gross Amount: {total:C}");
            Console.WriteLine($"Discount: {SmallDiscountPercentage}%");            
            Console.WriteLine($"Net Amount: {NetValue:C}");
        }
        else 
        {
            decimal NetValue = total * largeDiscount;
            Console.WriteLine($"Gross Amount: {total:C}");
            Console.WriteLine($"Discount: {LargeDiscountPercentage}%");
            Console.WriteLine($"Net Amount: {NetValue:C}");
        }
              
        
    }
    static void Main()
    {
        Discount discount = new Discount();
        
        decimal Total = discount.GetItems();
        discount.GetDiscount(Total);
    }
}