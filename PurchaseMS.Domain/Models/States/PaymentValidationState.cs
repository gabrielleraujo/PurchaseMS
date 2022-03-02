using PurchaseMS.Domain.Models.Entities;
using PurchaseMS.Domain.Models.States.Interfaces;

namespace PurchaseMS.Domain.Models.States
{
    public class PaymentValidationState : IPurchaseState
    {
        public void Initial(Purchase purchase)
        {
            throw new NotImplementedException("Initial has already been resolved");
        }

        public void ApplyDiscont(Purchase purchase)
        {
            throw new NotImplementedException("ApplyDiscont has already been resolved");
        }

        public void PaymentValidation(Purchase purchase)
        {
            throw new NotImplementedException("PaymentValidation has already been resolved");
        }

        public void Authorized(Purchase purchase)
        {
            purchase.State = new AuthorizedState();
        }

        public void Unauthorized(Purchase purchase)
        {
            purchase.State = new UnauthorizedState();
        }
    }
}