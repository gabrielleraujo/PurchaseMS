namespace PurchaseMS.CrossCutting.Dtos
{
    public class CreatePurchaseItemDTO
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public InputProductDTO Product { get; set; }
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }
    }
}