using PurchaseMS.Domain.Models.Entities;
using PurchaseMS.Domain.Models.States.Interfaces;

namespace PurchaseMS.Domain.Models.States
{
    public class AuthorizedState : IPurchaseState
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
            throw new NotImplementedException("AuthorizedPayment has already been resolved");
        }

        public void Unauthorized(Purchase purchase)
        {
            throw new NotImplementedException("UnauthorizedPayment has already been resolved");
        }
    }
}