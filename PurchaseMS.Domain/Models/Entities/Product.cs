using PurchaseMS.Domain.Models.Abstracts;
using PurchaseMS.Domain.Models.ValueObjects;

namespace PurchaseMS.Domain.Models.Entities
{
    public class Product : Entity
    {
        private Product() { }
        public Product(int id, string name, double price, string description, Category category, Color color, Size size) : base(id)
        {
            Name = name;
            Price = price;
            Description = description;
            Category = category;
            Color = color;
            Size = size;
        }

        public string Name { get; private set; }
        public double Price { get; private set; }
        public string Description { get; private set; }

        public Category Category { get; private set; }
        public Color Color { get; private set; }
        public Size Size { get; private set; }
    }
}