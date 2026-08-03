using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        // Read two lines directly
        string word1 = Console.ReadLine();
        string word2 = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(word1) || string.IsNullOrWhiteSpace(word2))
            return;

        // Clean up any extra trailing whitespace/newlines
        word1 = word1.Trim();
        word2 = word2.Trim();

        HashSet<char> vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };

        // Collect consonants from word2
        HashSet<char> word2Consonants = new HashSet<char>();
        foreach (char c in word2)
        {
            char lowerC = char.ToLower(c);
            if (char.IsLetter(lowerC) && !vowels.Contains(lowerC))
            {
                word2Consonants.Add(lowerC);
            }
        }

        // Task 1: Remove common consonants
        StringBuilder task1Result = new StringBuilder();
        foreach (char c in word1)
        {
            char lowerC = char.ToLower(c);
            if (vowels.Contains(lowerC) || !word2Consonants.Contains(lowerC))
            {
                task1Result.Append(c);
            }
        }

        // Task 2: Remove consecutive duplicate characters (case-insensitive)
        StringBuilder finalResult = new StringBuilder();
        for (int i = 0; i < task1Result.Length; i++)
        {
            if (i == 0 || char.ToLower(task1Result[i]) != char.ToLower(task1Result[i - 1]))
            {
                finalResult.Append(task1Result[i]);
            }
        }

        Console.WriteLine(finalResult.ToString());
    }
}