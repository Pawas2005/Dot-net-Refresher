using System;

namespace PayrollSystem
{
    public class Employee
    {
        public string Name { get; set; }
        public double WorkingHour { get; set; }
        public double HourlyRate { get; set; }

        public Employee(string name, double hour, double rate)
        {
            Name = name;
            WorkingHour = hour;
            HourlyRate = rate;
        }
    }
}