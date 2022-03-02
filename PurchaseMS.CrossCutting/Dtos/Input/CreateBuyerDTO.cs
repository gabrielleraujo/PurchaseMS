namespace PurchaseMS.CrossCutting.Dtos
{
    public class CreateBuyerDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public string Username { get; set; }
        public string Email { get; set; }
    }
}