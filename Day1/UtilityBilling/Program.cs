using System;

interface IBillCalculator
{
    double CalculateBill(double units, double rate, double fixedCharges);
}

class ResidentialCustomer : IBillCalculator
{
    public double CalculateBill(double units, double rate, double fixedCharges)
    {
        return (units * rate) + fixedCharges;
    }
}

class CommercialCustomer : IBillCalculator
{
    public double CalculateBill(double units, double rate, double fixedCharges)
    {
        double bill = (units * rate) + fixedCharges;
        return bill + (bill * 0.10);
    }
}

public class Program
{
    public static void Main()
    {
        double units, rates, fixedCharges;

        Console.Write("Enter Customer Type (Residential/Commercial): ");
        string customerType = Console.ReadLine();

        Console.Write("Enter units Consumed: ");
        while(!double.TryParse(Console.ReadLine(), out units) || units < 0)
        {
            Console.WriteLine("Invalid units! Enter a non-negative number.");
            Console.Write("Enter Units Consumed: ");
        }

        Console.Write("Enter Rate Per Unit: ");
        while(!double.TryParse(Console.ReadLine(), out rates) || rates < 0)
        {
            Console.WriteLine("Invalid rate! Enter a non-negative number.");
            Console.Write("Enter Rate Per Unit: ");
        }

        Console.Write("Enter Fixed Charges: ");
        while(!double.TryParse(Console.ReadLine(), out fixedCharges) || fixedCharges < 0)
        {
            Console.WriteLine("Invalid fixed charges! Enter a non-negative number.");
            Console.Write("Enter Fixed Charges: ");
        }

        IBillCalculator billCalculator;

        if(customerType.Equals("Residential", StringComparison.OrdinalIgnoreCase))
        {
            billCalculator = new ResidentialCustomer();
        }
        else if(customerType.Equals("Commercial", StringComparison.OrdinalIgnoreCase))
        {
            billCalculator = new CommercialCustomer();
        }
        else
        {
            Console.WriteLine("Invalid Customer Type.");
            return;
        }

        double totalBill = billCalculator.CalculateBill(units, rates, fixedCharges);

        Console.WriteLine("\n------ Electricity Bill ------");
        Console.WriteLine($"Customer Type : {customerType}");
        Console.WriteLine($"Units         : {units}");
        Console.WriteLine($"Rate          : {rates:F2}");
        Console.WriteLine($"Fixed Charges : {fixedCharges:F2}");
        Console.WriteLine($"Total Bill    : {totalBill:F2}");
    }
}