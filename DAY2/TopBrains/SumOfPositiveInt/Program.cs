using System;

public class Solution
{
    public int SumPositiveIntegers(int[] nums)
    {
        int sum = 0;

        foreach (int num in nums)
        {
            // Stop if 0 is encountered
            if (num == 0)
                break;

            // Ignore negative numbers
            if (num < 0)
                continue;

            // Add positive numbers
            sum += num;
        }

        return sum;
    }

    public static void Main()
    {
        Solution obj = new Solution();

        int[] nums = { 5, -2, 8, 3, -1, 0, 10, 20 };

        Console.WriteLine(obj.SumPositiveIntegers(nums));
    }
}