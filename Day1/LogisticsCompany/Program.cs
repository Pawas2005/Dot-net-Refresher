using System;

namespace LogisticsCompany
{
    public class Program
    {
        public static void Main()
        {
            string packageType;
            double weight;
            double distance;

            Console.Write("Enter Package Type (Standard/Express): ");
            packageType = Console.ReadLine();

            Console.Write("Enter Weight(in Kg): ");
            while(!double.TryParse(Console.ReadLine(), out weight) || weight <= 0 || weight > 1000)
            {
                Console.WriteLine("Invalid Weight! Enter a value between 1 and 1000 kg.");
                Console.Write("Enter Weight (kg): ");
            }

            Console.Write("Enter Distance(in Km): ");
            while(!double.TryParse(Console.ReadLine(), out distance) || distance <= 0 || distance > 10000)
            {
                Console.WriteLine("Invalid Distance! Enter a value between 1 and 10000 km.");
                Console.Write("Enter Distance (km): ");
            }

            IShippingCalculator shippingCalculator;

            if(packageType.Equals("Standard", StringComparison.OrdinalIgnoreCase) == true)
            {
                shippingCalculator = new StandardPackage();
            }
            else if(packageType.Equals("Express", StringComparison.OrdinalIgnoreCase) == true)
            {
                shippingCalculator = new ExpressPackage();
            }
            else
            {
                Console.WriteLine("Invalid Package Type.");
                return;
            }

            double shippingCost = shippingCalculator.CalculateShippingCost(weight, distance);

            Console.WriteLine("\n------ Shipping Summary ------");
            Console.WriteLine($"Package Type : {packageType}");
            Console.WriteLine($"Weight       : {weight} kg");
            Console.WriteLine($"Distance     : {distance} km");
            Console.WriteLine($"Shipping Cost: ₹{Math.Round(shippingCost, 2):F2}");
        }
    }
}