using System;

public class Solution
{
    public static int LargestInteger(int a, int b, int c)
    {
        if (a >= b && a >= c)
            return a;
        else if (b >= a && b >= c)
            return b;
        else
            return c;
    }

    public static void Main()
    {
        int a = 10;
        int b = 25;
        int c = 15;

        Console.WriteLine(LargestInteger(a, b, c));
    }
}