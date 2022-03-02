using PurchaseMS.Domain.Models.Entities;

namespace PurchaseMS.Domain.Models.Discounts
{
    public abstract class Discount
    {
        protected Discount(double discountValue)
        {
            DiscountValue = discountValue;
        }

        public double DiscountValue { get; protected set; }
        public Discount Next { get; set; }

        public abstract void Calculate(Purchase purchase, CurrentPrice currentPrice);
    }
}