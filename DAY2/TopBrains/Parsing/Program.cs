using System;

public class Solution
{
    public int SumParsedIntegers(string[] tokens)
    {
        int sum = 0;

        foreach (string token in tokens)
        {
            int value;

            if (int.TryParse(token, out value))
            {
                sum += value;
            }
        }

        return sum;
    }

    public static void Main()
    {
        Solution obj = new Solution();

        string[] tokens = { "10", "20", "abc", "2147483648", "-5", "100" };

        Console.WriteLine(obj.SumParsedIntegers(tokens));
    }
}