using System;
using System.Collections.Generic;

namespace BikeRentalAssignment;

public class Program
{
    public static void Main()
    {
        BikeUtility bikeUtility = new BikeUtility();

        while(true)
        {
            Console.WriteLine("\n1. Add Bike");
            Console.WriteLine("2. Group Bikes By Brand");
            Console.WriteLine("3. Exit");

            Console.Write("Enter Your Choice : ");
            int choice = int.Parse(Console.ReadLine());

            if(choice == 1)
            {
                Console.Write("Enter Model: ");
                string model = Console.ReadLine();

                Console.Write("Enter Brand: ");
                string brand = Console.ReadLine();

                Console.Write("Enter Price Per Day: ");
                int price = int.Parse(Console.ReadLine());

                bikeUtility.AddBikeDetails(model, brand, price);
                Console.WriteLine("Bike Added Successfully");
            }
            else if(choice == 2)
            {
                SortedDictionary<string, List<Bike>> groups = bikeUtility.GroupBikesByBrand();
                Console.WriteLine("\nGrouped Bikes:");

                foreach(var brand in groups)
                {
                    Console.WriteLine(brand.Key);

                    foreach(Bike bike in brand.Value)
                    {
                        Console.WriteLine("   " + bike.Model + " - ₹" + bike.PricePerDay);
                    }
                }
            }
            else if (choice == 3)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid Choice");
            }
        }
    }
}