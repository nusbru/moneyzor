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
        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }

        [Required]
        public TransactionType Type { get; set; }

        [Required]
        [ForeignKey("AccountId")]
        public Guid AccountId { get; set; } = Guid.Empty;
    }
}