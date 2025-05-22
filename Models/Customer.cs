using System.ComponentModel.DataAnnotations;

namespace MvcClient.Models
{
    public class Customer : Person
    {
        [Required]
        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}\-\d{2}$", ErrorMessage = "Invalid CPF format.")]
        public string CPF { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        public DateTime? BirthDate { get; set; }
    }
}