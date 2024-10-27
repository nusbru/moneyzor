using System.ComponentModel.DataAnnotations;

namespace moneyzor.Entities
{

    public class Account
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Balance { get; set; }
        public List<Transaction> Transactions { get; set; } = new List<Transaction>();
    }
}