using System;

namespace ECommerceDiscountCalc
{
    public class PremiumCustomer : Customer
    {
        public override double CalculateDiscount(double purchaseAmount)
        {
            return purchaseAmount * 0.10;
        }
    }
}