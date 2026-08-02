using System;

namespace ECommerceDiscountCalc
{
    public class Solution
    {
        public static void Main()
        {
            string? customerType;
            double purchaseAmount;

            Console.Write("Enter Customer Type (R/P/V): ");
            customerType = Console.ReadLine();

            Console.Write("Enter Purchase Amount: ");

            while (!double.TryParse(Console.ReadLine(), out purchaseAmount) || purchaseAmount < 0)
            {
                Console.WriteLine("Invalid amount! Enter a non-negative value.");
                Console.Write("Enter Purchase Amount: ");
            }

            Customer customer;

            switch(customerType?.ToUpper())
            {
                case "R":
                    customer = new RegularCustomer();
                    break;

                case "P":
                    customer = new PremiumCustomer();
                    break;

                case "V":
                    customer = new VIPCustomer();
                    break;

                default:
                    Console.WriteLine("Invalid Customer Type.");
                    return;
            }

            double discount = customer.CalculateDiscount(purchaseAmount);
            double finalPrice = purchaseAmount - discount;

            Console.WriteLine("\n------ Bill Summary ------");
            Console.WriteLine($"Original Price : ${purchaseAmount:F2}");
            Console.WriteLine($"Discount       : ${discount:F2}");
            Console.WriteLine($"Final Price    : ${finalPrice:F2}");
        }
    }
}