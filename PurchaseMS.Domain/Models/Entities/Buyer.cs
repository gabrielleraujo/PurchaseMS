using PurchaseMS.Domain.Models.Abstracts;

namespace PurchaseMS.Domain.Models.Entities
{
    public class Buyer : Entity
    {
        private Buyer() { }
        public Buyer(int id, string name, string surname, string username, string email) : base(id)
        {
            Name = name;
            Surname = surname;
            Username = username;
            Email = email;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }

        public string Username { get; private set; }
        public string Email { get; private set; }
    }
}