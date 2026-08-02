using System;

namespace ECommerceDiscountCalc
{
    public abstract class Customer
    {
        public abstract double CalculateDiscount(double purchaseAmount);
    } 
}