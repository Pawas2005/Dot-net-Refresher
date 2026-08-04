using System;
using System.IO;

public class Solution
{
    public static void Main()
    {
        string inputFile = "log.txt";
        string outputFile = "error.txt";

        if (File.Exists(inputFile))
        {
            string[] logs = File.ReadAllLines(inputFile);

            using (StreamWriter writer = new StreamWriter(outputFile))
            {
                foreach (string log in logs)
                {
                    if (log.Contains("ERROR"))
                    {
                        writer.WriteLine(log);
                    }
                }
            }

            Console.WriteLine("ERROR logs extracted successfully.");
        }
        else
        {
            Console.WriteLine("Input file not found.");
        }
    }
}