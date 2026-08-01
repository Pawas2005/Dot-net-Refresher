using System;
using System.Security.Principal;

public class Program
{
    public static void Main()
    {
        double m1, m2, m3, m4, m5;

        Console.Write("Enter Marks for Subject 1: ");
        while (!double.TryParse(Console.ReadLine(), out m1) || m1 < 0 || m1 > 100)
        {
            Console.WriteLine("Invalid marks! Enter a value between 0 and 100.");
            Console.Write("Enter Marks for Subject 1: ");
        }

        // Subject 2
        Console.Write("Enter Marks for Subject 2: ");
        while (!double.TryParse(Console.ReadLine(), out m2) || m2 < 0 || m2 > 100)
        {
            Console.WriteLine("Invalid marks! Enter a value between 0 and 100.");
            Console.Write("Enter Marks for Subject 2: ");
        }

        // Subject 3
        Console.Write("Enter Marks for Subject 3: ");
        while (!double.TryParse(Console.ReadLine(), out m3) || m3 < 0 || m3 > 100)
        {
            Console.WriteLine("Invalid marks! Enter a value between 0 and 100.");
            Console.Write("Enter Marks for Subject 3: ");
        }

        // Subject 4
        Console.Write("Enter Marks for Subject 4: ");
        while (!double.TryParse(Console.ReadLine(), out m4) || m4 < 0 || m4 > 100)
        {
            Console.WriteLine("Invalid marks! Enter a value between 0 and 100.");
            Console.Write("Enter Marks for Subject 4: ");
        }

        Console.Write("Enter Marks for Subject 5: ");
        while (!double.TryParse(Console.ReadLine(), out m5) || m5 < 0 || m5 > 100)
        {
            Console.WriteLine("Invalid marks! Enter a value between 0 and 100.");
            Console.Write("Enter Marks for Subject 5: ");
        }

        double total = m1 + m2 + m3 + m4 + m5;
        double average = total / 5;
        double percentage = (total / 500) * 100;

        // Output
        Console.WriteLine("\n----- Student Result -----");
        Console.WriteLine($"Total Marks : {total:F2}");
        Console.WriteLine($"Average     : {average:F2}");
        Console.WriteLine($"Percentage  : {Math.Round(percentage, 2):F2}%");
    }
}