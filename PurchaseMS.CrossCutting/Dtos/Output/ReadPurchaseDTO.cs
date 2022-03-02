namespace PurchaseMS.CrossCutting.Dtos
{
    public class ReadPurchaseDTO
	{
        public int Id { get; set; }
        public ReadBuyerDTO Buyer { get; set; }
        public IList<ReadPurchaseItemDTO> PurchaseItems { get; set; }
        public ReadAddressDTO Address { get; set; }
        public DateTime Date { get; set; }
        public double Price { get; set; }
        public bool HasSummary { get; set; }
        public double FreightValue { get; set; }
        public string Status { get; set; }
    }
}