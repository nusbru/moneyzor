using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace moneyzor.Entities
{
    public class Transaction
    {
        [Key]
        public Guid Id { get; set; }
        [MaxLength(100)]
        public string Description { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Amount { get; set; }

        [Required]
        public DateTime Date { get; set; } = DateTime.UtcNow;

        [Required]
        public int CategoryId { get; set; }
        public TransactionCategory Category { get; set; } = new();

        [Required]
        public TransactionType Type { get; set; } = TransactionType.None;

        [Required]
        public Guid AccountId { get; set; }
        public Account Account { get; set; } = new();
    }
}