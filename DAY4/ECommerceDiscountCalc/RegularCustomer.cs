using System;

namespace ECommerceDiscountCalc
{
    public class RegularCustomer : Customer
    {
        public override double CalculateDiscount(double purchaseAmount)
        {
            if(purchaseAmount > 100)
                return purchaseAmount * 0.05;

            return 0;
        }
    }
}