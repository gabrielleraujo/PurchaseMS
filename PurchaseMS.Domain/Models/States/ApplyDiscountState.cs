using PurchaseMS.Domain.Models.Entities;
using PurchaseMS.Domain.Models.States.Interfaces;

namespace PurchaseMS.Domain.Models.States
{
    public class ApplyDiscontState : IPurchaseState
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
            purchase.State = new PaymentValidationState();
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