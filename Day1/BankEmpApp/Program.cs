using System;

public class Program
{
    public static void Main()
    {
        double openingBalance, deposits, withdrawals;

        Console.Write("Enter Opening Balance: ");
        while (!double.TryParse(Console.ReadLine(), out openingBalance) || openingBalance < 0)
        {
            Console.WriteLine("Invalid opening balance! Please enter a non-negative number.");
            Console.Write("Enter Opening Balance: ");
        }

        Console.Write("Enter Total Deposits: ");
        while (!double.TryParse(Console.ReadLine(), out deposits) || deposits < 0)
        {
            Console.WriteLine("Invalid deposit amount! Please enter a non-negative number.");
            Console.Write("Enter Total Deposits: ");
        }

        Console.Write("Enter Total Withdrawals: ");
        while (!double.TryParse(Console.ReadLine(), out withdrawals) || withdrawals < 0)
        {
            Console.WriteLine("Invalid withdrawal amount! Please enter a non-negative number.");
            Console.Write("Enter Total Withdrawals: ");
        }

        double availableBal = openingBalance + deposits;

        if(withdrawals > availableBal)
        {
            Console.WriteLine("\nError: Insufficient funds! Withdrawal exceeds available balance.");
            return;
        }        

        double finalbalance = availableBal - withdrawals;

        Console.WriteLine("\n----- Account Summary -----");
        Console.WriteLine($"Opening Balance : {openingBalance:F2}");
        Console.WriteLine($"Deposits        : {deposits:F2}");
        Console.WriteLine($"Withdrawals     : {withdrawals:F2}");
        Console.WriteLine($"Final Balance   : {Math.Round(finalbalance, 2):F2}");
    }
}