using System;

namespace LogisticsCompany
{
    public interface IShippingCalculator
    {
        double CalculateShippingCost(double weight, double distance);
    }
}