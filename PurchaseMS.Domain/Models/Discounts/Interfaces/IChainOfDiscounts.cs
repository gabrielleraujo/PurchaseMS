using PurchaseMS.Domain.Models.Entities;

namespace PurchaseMS.Domain.Models.Discounts.Interfaces
{
    public interface IChainOfDiscounts
    {
        /// <summary>
        /// Returns the total price to be paid after all possible discounts have been applied to the purchase.
        /// </summary>
        /// <param name="purchase"></param>
        /// <returns></returns>
        double CalculateDiscount(Purchase purchase);
    }
}