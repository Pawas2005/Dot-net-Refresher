using System;

public class Solution
{
    // Function to calculate sum of digits
    static int SumOfDigits(long num)
    {
        int sum = 0;
        while (num > 0)
        {
            sum += (int)(num % 10);
            num /= 10;
        }
        return sum;
    }

    // Function to check prime
    static bool IsPrime(int n)
    {
        if (n <= 1)
            return false;

        if (n == 2)
            return true;

        if (n % 2 == 0)
            return false;

        for (int i = 3; i * i <= n; i += 2)
        {
            if (n % i == 0)
                return false;
        }

        return true;
    }

    public static void Main()
    {
        int m = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        int count = 0;

        for (int x = m; x <= n; x++)
        {
            if (!IsPrime(x))
            {
                int s = SumOfDigits(x);
                int sq = SumOfDigits((long)x * x);

                if (sq == s * s)
                    count++;
            }
        }

        Console.WriteLine(count);
    }
}