using System;

public class Program
{
    public static void Main()
    {
        double length, width, height;

        Console.Write("Enter Length: ");
        while (!double.TryParse(Console.ReadLine(), out length) || length <= 0)
        {
            Console.WriteLine("Invalid Length! Please enter a positive number.");
            Console.Write("Enter Length: ");
        }

        Console.Write("Enter Width: ");
        while (!double.TryParse(Console.ReadLine(), out width) || width <= 0)
        {
            Console.WriteLine("Invalid Width! Please enter a positive number.");
            Console.Write("Enter Width: ");
        }

        Console.Write("Enter Height: ");
        while (!double.TryParse(Console.ReadLine(), out height) || height <= 0)
        {
            Console.WriteLine("Invalid Height! Please enter a positive number.");
            Console.Write("Enter Height: ");
        }

        // Calculations
        double volume = length * width * height;

        // Output
        Console.WriteLine("\n----- Package Details -----");
        Console.WriteLine($"Length : {length}");
        Console.WriteLine($"Width  : {width}");
        Console.WriteLine($"Height : {height}");
        Console.WriteLine($"Volume : {Math.Round(volume, 2):F2} cubic units");
    }
}