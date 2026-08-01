using System;

namespace LogisticsCompany
{
    public class ExpressPackage : IShippingCalculator
    {
        public double CalculateShippingCost(double weight, double distance)
        {
            return (weight * distance * 3) + 100;
        }
    }
}