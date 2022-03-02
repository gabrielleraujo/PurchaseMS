using System.ComponentModel.DataAnnotations;

namespace PurchaseMS.Domain.Models.Abstracts
{
    public abstract class Entity
    {
        protected Entity()
        { }

        protected Entity(int id)
        {
            Id = id;
        }

        [Key]
        public int Id { get; private set; }
    }
}