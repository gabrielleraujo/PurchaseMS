using PurchaseMS.Domain.Models.Abstracts;

namespace PurchaseMS.Domain.Models.ValueObjects
{
    public class Size : ValueObject
    {
        private Size() { }

        public Size(string text)
        {
            SizeText = text;
        }

        public string SizeText { get; private set; }
    }
}