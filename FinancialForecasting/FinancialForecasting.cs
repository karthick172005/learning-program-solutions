using System;

class FinancialForecasting
{
    static void Main()
    {
        double initialValue = 10000; // ₹10,000 investment
        double growthRate = 0.08;    // 8% annual growth
        int years = 5;               // Forecast for 5 years

        double futureValue = ForecastRecursive(initialValue, growthRate, years);

        Console.WriteLine($"Predicted Value after {years} years: ₹{futureValue:F2}");
    }

    // Recursive function to calculate future value
    static double ForecastRecursive(double currentValue, double rate, int yearsLeft)
    {
        if (yearsLeft == 0)
            return currentValue; // Base case

        // Recursive step
        return ForecastRecursive(currentValue * (1 + rate), rate, yearsLeft - 1);
    }
}
