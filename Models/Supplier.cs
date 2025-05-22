using System.ComponentModel.DataAnnotations;

namespace MvcClient.Models
{
    public class Supplier : Person
    {
        [Required]
        [RegularExpression(@"^\d{2}\.\d{3}\.\d{3}/\d{4}-\d{2}$", ErrorMessage = "Invalid CNPJ format.")]
        public string CNPJ { get; set; } = string.Empty;

        [Display(Name = "Razão Social")]
        [StringLength(120, MinimumLength = 3)]
        [Required]
        public string? CompanyName { get; set; }

        [Display(Name = "Nome Fantasia")]
        [StringLength(120, MinimumLength = 3)]
        public string? TradeName { get; set; }
    }
}
