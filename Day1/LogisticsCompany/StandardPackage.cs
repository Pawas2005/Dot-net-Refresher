using System;

namespace LogisticsCompany
{
    public class StandardPackage : IShippingCalculator
    {
        public double CalculateShippingCost(double weight, double distance)
        {
            return weight * distance * 2;
        }
    }
}