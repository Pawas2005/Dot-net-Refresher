using System;

public class Solution
{
    public int GCD(int a, int b)
    {
        if (b == 0)
            return a;

        return GCD(b, a % b);
    }

    public static void Main()
    {
        Solution obj = new Solution();

        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine(obj.GCD(a, b));
    }
}