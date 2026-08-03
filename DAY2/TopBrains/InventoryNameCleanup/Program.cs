using System;
using System.Globalization;
using System.Text;

public class Solution
{
    public static string InventoryNameCleanup(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            return "";

        // Trim extra spaces
        input = input.Trim();

        StringBuilder sb = new StringBuilder();

        // Remove duplicate consecutive characters
        foreach (char ch in input)
        {
            if (sb.Length == 0 || sb[sb.Length - 1] != ch)
            {
                sb.Append(ch);
            }
        }

        // Remove extra spaces between words
        string cleaned = string.Join(" ",
            sb.ToString().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));

        // Convert to Title Case
        TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
        cleaned = textInfo.ToTitleCase(cleaned.ToLower());

        return cleaned;
    }

    public static void Main()
    {
        string? input = Console.ReadLine();

        Console.WriteLine(InventoryNameCleanup(input));
    }
}