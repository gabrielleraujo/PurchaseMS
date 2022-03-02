using PurchaseMS.Domain.Models.Entities;

namespace PurchaseMS.Domain.Models.Discounts
{
    public class FathersDayDiscount : Discount
    {
        public FathersDayDiscount(double discountValue = 0.30) : base(discountValue)
        {
        }

        public override void Calculate(Purchase purchase, CurrentPrice currentPrice)
        {
            if (purchase.Date.Month.Equals(8))
            {
                currentPrice.Price -= purchase.Price * DiscountValue;
            }

            Next.Calculate(purchase, currentPrice);
        }
    }
}