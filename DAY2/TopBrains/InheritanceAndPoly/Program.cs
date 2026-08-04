using System;

public class Program
{
    public static decimal CalculateTotalPayroll(string[] employees)
    {
        if (employees == null || employees.Length == 0)
            return 0.00m;

        decimal totalPay = 0m;

        foreach (string empStr in employees)
        {
            if (string.IsNullOrWhiteSpace(empStr))
                continue;

            string[] parts = empStr.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string type = parts[0];

            Employee employee = type switch
            {
                "H" => new HourlyEmployee(decimal.Parse(parts[1]), decimal.Parse(parts[2])),
                "S" => new SalariedEmployee(decimal.Parse(parts[1])),
                "C" => new CommissionEmployee(decimal.Parse(parts[1]), decimal.Parse(parts[2])),
                _ => throw new ArgumentException($"Invalid employee type: {type}")
            };

            totalPay += employee.GetPay();
        }

        return Math.Round(totalPay, 2, MidpointRounding.AwayFromZero);
    }

    public static void Main(string[] args)
    {
        // Sample input test cases
        string[] employees = new string[]
        {
            "H 25.50 40",       // Pay = 1020.00
            "S 5000",           // Pay = 5000.00
            "C 1200.75 3000"    // Pay = 4200.75
        };

        decimal totalPay = CalculateTotalPayroll(employees);
        Console.WriteLine($"Total Payroll: {totalPay:F2}");
    }
}