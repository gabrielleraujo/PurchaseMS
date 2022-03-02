namespace PurchaseMS.CrossCutting.Dtos
{
    public class ReadPurchaseItemDTO
    {
        public int Id { get; set; }
        public int PurchaseId { get; set; }
        public int ProductId { get; set; }
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }
    }
}