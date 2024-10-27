using System.ComponentModel.DataAnnotations;

namespace moneyzor.Entities
{
    public class TransactionCategory
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;
    }
}