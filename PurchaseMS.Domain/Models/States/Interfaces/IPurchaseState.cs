using PurchaseMS.Domain.Models.Entities;

namespace PurchaseMS.Domain.Models.States.Interfaces
{
    public interface IPurchaseState
    {
        void Initial(Purchase purchase);
        void ApplyDiscont(Purchase purchase);
        void PaymentValidation(Purchase purchase);
        void Authorized(Purchase payment);
        void Unauthorized(Purchase payment);
    }
}