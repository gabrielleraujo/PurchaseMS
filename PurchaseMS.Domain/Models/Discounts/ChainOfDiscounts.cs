using PurchaseMS.Domain.Models.Discounts.Interfaces;
using PurchaseMS.Domain.Models.Entities;

namespace PurchaseMS.Domain.Models.Discounts
{
    public class ChainOfDiscounts : IChainOfDiscounts
    {
        /// <summary>
        /// Returns the total price to be paid after all possible discounts have been applied to the purchase.
        /// </summary>
        /// <param name="purchase"></param>
        /// <returns></returns>
        public double CalculateDiscount(Purchase purchase)
        {
            var currentPrice = new CurrentPrice(purchase.Price);

            Discount discount1 = new PurchaseOver300ReaisDiscount();
            Discount discount2 = new FathersDayDiscount();
            Discount discount3 = new WithoutDiscount();

            discount1.Next = discount2;
            discount2.Next = discount3;

            discount1.Calculate(purchase, currentPrice);

            return currentPrice.Price;
        }
    }
}
