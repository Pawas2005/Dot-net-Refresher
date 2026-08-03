using System;

public class Solution
{
    public double? AverageNonNull(double?[] values)
    {
        double sum = 0;
        int count = 0;

        foreach (double? value in values)
        {
            if (value.HasValue)
            {
                sum += value.Value;
                count++;
            }
        }

        if (count == 0)
            return null;

        return Math.Round(sum / count, 2, MidpointRounding.AwayFromZero);
    }

    public static void Main()
    {
        Solution obj = new Solution();

        double?[] values = { 10.5, null, 20.5, 30.0, null };

        double? result = obj.AverageNonNull(values);

        if (result.HasValue)
            Console.WriteLine(result.Value);
        else
            Console.WriteLine("null");
    }
}