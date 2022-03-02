namespace PurchaseMS.CrossCutting.Dtos
{
    public class CreatePurchaseDTO
    {
        public CreateBuyerDTO Buyer { get; set; }
        public IList<CreatePurchaseItemDTO> PurchaseItems { get; set; }
        public CreateAddressDTO Address { get; set; }
        public DateTime Date { get; set; }
        public double Price { get; set; }
        public bool HasSummary { get; set; }
        public double FreightValue { get; set; }
    }
}