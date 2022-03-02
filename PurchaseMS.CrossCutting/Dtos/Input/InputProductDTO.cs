namespace PurchaseMS.CrossCutting.Dtos
{
    public class InputProductDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }

        public InputCategoryDTO Category { get; set; }
        public InputColorDTO Color { get; set; }
        public InputSizeDTO Size { get; set; }
    }
}