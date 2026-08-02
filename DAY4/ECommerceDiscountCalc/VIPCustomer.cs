using System;

namespace ECommerceDiscountCalc
{
    public class VIPCustomer : Customer
    {
        public override double CalculateDiscount(double purchaseAmount)
        {
            double discount = purchaseAmount * 0.15;

            if(purchaseAmount > 200)
                discount += purchaseAmount * 0.05;

            return discount;
        }
    }
}