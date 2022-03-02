using PurchaseMS.Domain.Models.Abstracts;

namespace PurchaseMS.Domain.Models.ValueObjects
{
    public class Category : ValueObject
    {
        private Category() { }
        public Category(string text)
        {
            CategoryText = text;
        }

        public string CategoryText { get; private set; }
    }
}