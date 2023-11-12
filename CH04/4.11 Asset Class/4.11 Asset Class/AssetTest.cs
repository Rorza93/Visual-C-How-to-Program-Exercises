// AssetTest
// create and manipulate Asset Information

using System;

class AssetTest
{
    static void Main()
    {

        Asset Asset001 = new Asset("Freezer", 7000m, 1000m, 2022);
        Asset001.getAssetInformation();
        Asset001.getDepreciation();
        decimal Asset001Appreciation = 5;
        Asset001.getAppreciation(Asset001Appreciation);
        Asset001.getDepreciation();

        Asset Asset002 = new Asset("Computer Monitor", 1000m, 250m, 2000);
        Asset002.getAssetInformation();
        Asset002.getDepreciation();
        decimal Asset002Appreciation = 5;
        Asset002.getAppreciation(Asset002Appreciation);
        Asset002.getDepreciation();


    }
}