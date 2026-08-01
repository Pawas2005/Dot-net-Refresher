using System;

namespace PayrollSystem
{
    public class Program
    {
        public static void Main()
        {
            string name;
            double hoursWorked;
            double hourlyRate;

            Console.Write("Enter Your Name: ");
            name = Console.ReadLine();

            Console.Write("Enter Hours Worked: ");
            while(!double.TryParse(Console.ReadLine(), out hoursWorked) || hoursWorked < 0 || hoursWorked > 168)
            {
                Console.WriteLine("Invalid hours! Enter a value between 0 and 168.");
                Console.Write("Enter Hours Worked: ");
            }

            Console.Write("Enter Hourly Rate: ");
            while(!double.TryParse(Console.ReadLine(), out hourlyRate) || hourlyRate <= 0)
            {
                Console.WriteLine("Invalid rate! Enter a positive number.");
                Console.Write("Enter Hourly Rate: ");
            }

            Employee employee = new Employee(name, hoursWorked, hourlyRate);

            PayrollCalculator calculator = new PayrollCalculator();

            double regularPay = calculator.CalculateRegularPay(employee);
            double overtimePay = calculator.CalculateOvertimePay(employee);
            double grosspay = calculator.CalculateGrossSalary(employee);

            Console.WriteLine("\n------ Payroll Summary ------");
            Console.WriteLine($"Employee Name: {employee.Name}");
            Console.WriteLine($"Hours Worked: {employee.WorkingHour}");
            Console.WriteLine($"Hourly Rate: {employee.HourlyRate}");
            Console.WriteLine($"Regular Pay   : {regularPay:F2}");
            Console.WriteLine($"Overtime Pay  : {overtimePay:F2}");
            Console.WriteLine($"Gross Salary  : {Math.Round(grosspay, 2):F2}");
        }
    }
}