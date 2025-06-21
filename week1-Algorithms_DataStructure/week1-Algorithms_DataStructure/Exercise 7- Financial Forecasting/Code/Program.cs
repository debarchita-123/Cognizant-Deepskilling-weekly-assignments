using System;

class FinancialForecast
{
    public static double FutureValueRecursive(double initialValue, double growthRate, int periods)
    {
        if (periods == 0)
        {
            return initialValue;
        }
        return FutureValueRecursive(initialValue, growthRate, periods - 1) * (1 + growthRate);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter the Initial value:");
        double initialValue = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the growth rate in decimal form (e.g., 0.05 for 5%):");
        double growthRate = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the period in years:");
        int periods = Convert.ToInt32(Console.ReadLine());

        double futureValue = FutureValueRecursive(initialValue, growthRate, periods);
        Console.WriteLine($"Future Value after {periods} periods: {futureValue}");
    }
}
