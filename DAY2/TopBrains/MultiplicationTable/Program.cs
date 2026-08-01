using System;

public class Solution
{
    public static int[] MultiplicationRow(int n, int upto)
    {
        int[] row = new int[upto];

        for (int i = 1; i <= upto; i++)
        {
            row[i - 1] = n * i;
        }

        return row;
    }

    public static void Main()
    {
        int n = 3;
        int upto = 5;

        int[] result = MultiplicationRow(n, upto);

        Console.WriteLine("[" + string.Join(",", result) + "]");
    }
}