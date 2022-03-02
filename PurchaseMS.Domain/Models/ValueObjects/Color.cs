using PurchaseMS.Domain.Models.Abstracts;

namespace PurchaseMS.Domain.Models.ValueObjects
{
    public class Color : ValueObject
    {
        private Color() { }

        public Color(string text)
        {
            ColorText = text;
        }

        public string ColorText { get; private set; }
    }
}