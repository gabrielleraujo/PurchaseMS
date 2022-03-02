using PurchaseMS.Domain.Models.Abstracts;

namespace PurchaseMS.Domain.Models.Entities
{
    public class PurchaseItem : Entity
    {
        private PurchaseItem() { }
        public PurchaseItem(int id, int productId, Product product, double unitPrice, int quantity) : base(id)
        {
            ProductId = productId;
            Product = product;
            UnitPrice = unitPrice;
            Quantity = quantity;
        }

        public int PurchaseId { get; set; }
        public int ProductId { get; private set; }
        public Product Product { get; private set; }
        public double UnitPrice { get; private set; }
        public int Quantity { get; private set; }
    }
}