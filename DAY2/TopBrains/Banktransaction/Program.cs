using System;

public class Solution
{
    public int FinalBalance(int initialBalance, int[] transactions)
    {
        int balance = initialBalance;

        foreach (int transaction in transactions)
        {
            if (transaction >= 0)
            {
                // Deposit
                balance += transaction;
            }
            else
            {
                // Withdraw only if enough balance
                if (balance >= -transaction)
                {
                    balance += transaction; // transaction is negative
                }
            }
        }

        return balance;
    }

    public static void Main()
    {
        Solution obj = new Solution();

        int initialBalance = 1000;
        int[] transactions = { 500, -200, -1500, 300, -400 };

        int finalBalance = obj.FinalBalance(initialBalance, transactions);

        Console.WriteLine(finalBalance);
    }
}