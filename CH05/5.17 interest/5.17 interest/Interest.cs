// Interest.cs
// Determine the interest over a month on a sentinal determnined amount of investments
using System;

class Interest
{
    static void Main()
    { 
        InterestApplicator investment001 = new InterestApplicator(0, 0);        

        investment001.GetInterestApplicator();
    }
}