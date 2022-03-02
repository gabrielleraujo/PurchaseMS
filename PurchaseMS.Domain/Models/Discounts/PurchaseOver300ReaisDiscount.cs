using PurchaseMS.Domain.Models.Entities;

namespace PurchaseMS.Domain.Models.Discounts
{
    public class PurchaseOver300ReaisDiscount : Discount
    {
        public PurchaseOver300ReaisDiscount(double discountValue = 0.25) : base(discountValue)
        {
        }

        public override void Calculate(Purchase purchase, CurrentPrice currentPrice)
        {
            if (purchase.Price > 300.0)
            {
                currentPrice.Price -= purchase.Price * DiscountValue;
            }

            Next.Calculate(purchase, currentPrice);
        }
    }
}