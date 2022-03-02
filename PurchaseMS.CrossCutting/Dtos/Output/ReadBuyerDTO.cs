namespace PurchaseMS.CrossCutting.Dtos
{
    public class ReadBuyerDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public string Username { get; set; }
        public string Email { get; set; }
    }
}