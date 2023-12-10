// Population.cs
// Used to determine the population increase over the next 75 years
using System;
using Microsoft.VisualBasic;

class Population
{
    static void Main()
    {
        double populationIncreasePercentage = 1.009;
        double totalPopulation = 8077595932;
        double temp = 0;
        double populationIncreaseValue = 0;
        Console.WriteLine($"Year | Estimated Population | Increase over Last Year");
        for (int year = 1; year <= 75; year++)
        {
            temp = totalPopulation;
            totalPopulation *= populationIncreasePercentage;
            populationIncreaseValue = totalPopulation - temp;
            Console.WriteLine($"{year,-6} {totalPopulation.ToString("F0"),-22} {populationIncreaseValue.ToString("F0"),-25}");
        }
    }
}