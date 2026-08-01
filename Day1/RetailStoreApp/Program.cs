using System;

public class Program
{
    public static void Main()
    {
        double price;
        int quantity;
        double discount;

        Console.Write("Enter the Item Price: ");
        while(!double.TryParse(Console.ReadLine(), out price) || price < 0)
        {
            Console.WriteLine("Invalid Price! Please enter a non-negative negative number.");
            Console.Write("Enter the Item Price: ");
        }

        Console.Write("Enter the quantity: ");
        while(!int.TryParse(Console.ReadLine(), out quantity) || quantity < 0)
        {
            Console.WriteLine("Invalid Quantity! Please enter a non-negative value.");
            Console.Write("Enter Quantity: ");
        }

        Console.Write("Enter the Discount Percentage: ");
        while(!double.TryParse(Console.ReadLine(), out discount) || discount < 0 || discount > 100)
        {
            Console.WriteLine("Invalid Disount! Enter a value between 0 and 100.");
        }

        //Calculations
        double subtotal = price * quantity;
        double disAmt = subtotal * discount / 100;
        double finalAmt = subtotal - disAmt;
        
        //Output
        Console.WriteLine("\n-------- Bill Details ----------");
        Console.WriteLine($"Subtotal : {Math.Round(subtotal, 2):F2}");
        Console.WriteLine($"Discount Amount : {Math.Round(disAmt, 2):F2}");
        Console.WriteLine($"Final Amount : {Math.Round(finalAmt, 2):F2}");
   }
}