using System;

public class Solution
{
    public string DisplayHeight(int heightCm)
    {
        if (heightCm < 150)
        {
            return "Short";
        }
        else if (heightCm < 180)
        {
            return "Average";
        }
        else
        {
            return "Tall";
        }
    }

    public static void Main(string[] args)
    {
        Solution obj = new Solution();

        int heightCm = int.Parse(Console.ReadLine());

        string category = obj.DisplayHeight(heightCm);

        Console.WriteLine(category);
    }
}