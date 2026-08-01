using System;

public class Program
{
    public static void Main()
    {
        double weight, height;

        Console.Write("Enter the Weight(in Kg): ");
        while(!double.TryParse(Console.ReadLine(), out weight) || weight <= 0)
        {
            Console.WriteLine("Invalid Weight! Enter the positive weight");
            Console.Write("Enter the weight(in Kg): ");
        }

        Console.Write("Enter the Height(in meter): ");
        while(!double.TryParse(Console.ReadLine(), out height) || height <= 0)
        {
            Console.WriteLine("Invalid height! Enter the positive height");
            Console.Write("Enter the height(in meter): ");
        }

        //Calculations
        double bmi = weight / (height * height);
        bmi = Math.Round(bmi, 2);

        string category;

        if (bmi < 18.5)
            category = "Underweight";
        else if (bmi < 25)
            category = "Normal Weight";
        else if (bmi < 30)
            category = "Overweight";
        else
            category = "Obese";

        // Output
        Console.WriteLine("\n----- BMI Report -----");
        Console.WriteLine($"BMI      : {bmi:F2}");
        Console.WriteLine($"Category : {category}");
    }
}