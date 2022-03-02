using PurchaseMS.Domain.Models.Abstracts;
using PurchaseMS.Domain.Models.Discounts.Interfaces;
using PurchaseMS.Domain.Models.States.Interfaces;
using PurchaseMS.Domain.Models.ValueObjects;

namespace PurchaseMS.Domain.Models.Entities
{
    public class Purchase : Entity
    {
        public Buyer Buyer { get; private set; }
        public int BuyerId { get; private set; }

        public DateTime Date { get; private set; }
        public IList<PurchaseItem> PurchaseItems { get; set; }
        public double Price { get; private set; }
        public bool HasSummary { get; private set; }

        public double FreightValue { get; private set; }
        public Address Address { get; private set; }
        public IPurchaseState State { get; internal set; }        //ignore

        private Purchase() { }
        public Purchase(Buyer buyer, int buyerId, Address address, DateTime date, double price, bool hasSummary, double freightValue, IPurchaseState state)
        {
            Buyer = buyer;
            BuyerId = buyerId;
            Address = address;
            Date = date;
            Price = price;
            HasSummary = hasSummary;
            FreightValue = freightValue;
            State = state;
        }

        public void UpdatePrice(double value)
        {
            if(value > 0)
            {
                Price = value;
            }
        }

        public double CalculateDiscont(IChainOfDiscounts chain)
        {
            var finalPrice = chain.CalculateDiscount(this);
            return finalPrice;
        }

        public void ApplyDiscont(IChainOfDiscounts chain)
        {
            State.ApplyDiscont(this);

            var finalPrice = CalculateDiscont(chain);
            UpdatePrice(finalPrice);
        }

        public void AddFreight()
        {
            UpdatePrice(Price += this.FreightValue);
        }

        public void CalculateTotalValue(IChainOfDiscounts chain)
        {
            ApplyDiscont(chain);
            AddFreight();
        }

        public void PaymentValidation()
        {
            State.PaymentValidation(this);
        }

        public void Authorized()
        {
            State.Authorized(this);
        }

        public void Unauthorized()
        {
            State.Unauthorized(this);
        }
    }
}