using PurchaseMS.Domain.Models.Entities;

namespace PurchaseMS.Domain.Models.Discounts
{
    public class WithoutDiscount : Discount
    {
        public WithoutDiscount(double discountValue = 0) : base(discountValue)
        {
        }

        public override void Calculate(Purchase purchase, CurrentPrice currentPrice){ }
    }
}