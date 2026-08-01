using System;

namespace PayrollSystem
{
    public class PayrollCalculator
    {
        public double CalculateRegularPay(Employee employee)
        {
            double regHour = Math.Min(employee.WorkingHour, 40);
            return regHour * employee.HourlyRate;
        }

        public double CalculateOvertimePay(Employee employee)
        {
            if(employee.WorkingHour <= 40)
                return 0;

            double overtimeHr = employee.WorkingHour - 40;

            return overtimeHr * employee.HourlyRate * 1.5; 
        }

        public double CalculateGrossSalary(Employee employee)
        {
            return CalculateRegularPay(employee) + CalculateOvertimePay(employee);
        }
    }
}