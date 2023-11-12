// Asset.cs 
// Class to display four pieces of information

class Asset
{ 
    public string AssetName { get; set; }   // auto implement variable
    private decimal assetValue;             // instance variable
    private decimal assetDepreciation;      // instance variable
    public int AssetYear;                   // auto implement variable

    // Asset constructor to initialise three parameters
    public Asset(string assetName, decimal assetValue, decimal assetDepreciation, int assetYear)
    {
        AssetName = assetName;
        AssetValue = assetValue;
        AssetDepreciation = assetDepreciation;
        AssetYear = assetYear;
    }

    // AssetValue property with validation
    public decimal AssetValue
    {
        get { return assetValue; }
        private set
        {
            if (value > 0)
            { 
                assetValue = value;
            }
        }
    }

    // AssetDepreciation property with validation
    public decimal AssetDepreciation
    {
        get { return assetDepreciation; }
        private set
        {
            if (value > 0)
            {
                assetDepreciation = value;
            }
        }
    }

    // Method to print Asset information
    public void getAssetInformation()
    {
        Console.WriteLine($"\nAsset Name: {AssetName}");
        Console.WriteLine($"Asset Year Purchased: {AssetYear}");
        Console.WriteLine($"Asset Value: {AssetValue:C}");
        Console.WriteLine($"Asset Depreciation: {AssetDepreciation:C}");
    }

    // Method to calculate depreciation
    public void getDepreciation()
    { 
        int assetYearsOld = (DateTime.Now.Year - AssetYear);
        decimal depreciation = (AssetValue - (AssetDepreciation * assetYearsOld));
        if (depreciation < 0)
            depreciation = 0m;
        Console.WriteLine($"After {assetYearsOld} years the value of the {AssetName} is {depreciation:C}");

    }

    // Method to calculate appreciation in %
    public void getAppreciation(decimal appreciationPercentage)
    {
        AssetValue = (AssetValue + AssetValue * (appreciationPercentage / 100));
        Console.WriteLine($"The value of {AssetName} has increase by {appreciationPercentage}%");
    }
}