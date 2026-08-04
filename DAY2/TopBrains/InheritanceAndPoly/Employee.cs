using System;

public abstract class Employee
{
    public abstract decimal GetPay();
}

public class HourlyEmployee : Employee
{
    public decimal Rate { get; set; }
    public decimal Hours { get; set; }

    public HourlyEmployee(decimal rate, decimal hours)
    {
        Rate = rate;
        Hours = hours;
    }

    public override decimal GetPay() => Rate * Hours;
}

public class SalariedEmployee : Employee
{
    public decimal MonthlySalary { get; set; }

    public SalariedEmployee(decimal monthlySalary)
    {
        MonthlySalary = monthlySalary;
    }

    public override decimal GetPay() => MonthlySalary;
}

public class CommissionEmployee : Employee
{
    public decimal Commission { get; set; }
    public decimal BaseSalary { get; set; }

    public CommissionEmployee(decimal commission, decimal baseSalary)
    {
        Commission = commission;
        BaseSalary = baseSalary;
    }

    public override decimal GetPay() => BaseSalary + Commission;
}