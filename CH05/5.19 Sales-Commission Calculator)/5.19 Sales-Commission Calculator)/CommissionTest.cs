// CommissionTest.cs
// app to test the Commission

using System;

class CommissionTest
{
    static void Main()
    { 
        Commission commission001 = new Commission(100,200,50,25);
        commission001.GetCommission();
    }
}