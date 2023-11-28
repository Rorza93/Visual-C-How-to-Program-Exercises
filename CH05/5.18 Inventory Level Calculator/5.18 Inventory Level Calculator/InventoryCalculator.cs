// InventoryCalculator.cs

// Determine whether the level of any
// of the items in a store’s inventory has fallen below 1% of the initial number of units

class InventoryCalculator
{ 
    private int ItemCode { get; set; }
    private int ItemUnits { get; set; }
    private int UnitsPurchased { get; set; }
    private int UnitsIssued { get; set; }

    public InventoryCalculator(int itemCode, int itemUnits, int unitsPurchased, int unitsIssued)
    { 
        ItemCode = itemCode;
        ItemUnits = itemUnits;
        UnitsPurchased = unitsPurchased;
        UnitsIssued = unitsIssued;
    }

    public void GetUnitWarning()
    {
        int LowerLimit = (ItemUnits/100);
        int RemainingUnits = (ItemUnits+UnitsPurchased-UnitsIssued);
        if (RemainingUnits < LowerLimit)
        {
            Console.WriteLine("Procure more units immediately");
        }
        else
        {
            Console.WriteLine("No more units need to be purchased");
        }
    }

    public void GetCalculator()
    {
        
        
        while (true)
        {
            Console.Write("Enter stop to exit or enter to continue: ");
            string input = Console.ReadLine();
            if (input == "stop")
            {
                break;
            }
            else
            {
                Console.Write("Enter item code: ");
                ItemCode = int.Parse(Console.ReadLine());

                Console.Write("Enter the initial number of units: : ");
                ItemUnits = int.Parse(Console.ReadLine());

                Console.Write("Enter the number of units purchased: ");
                UnitsPurchased = int.Parse(Console.ReadLine());

                Console.Write("Enter the number of units issued: ");
                UnitsIssued = int.Parse(Console.ReadLine());

                GetUnitWarning();
            }
        }
    }
    


}