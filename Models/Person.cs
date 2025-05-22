using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcClient.Models
{
    public abstract class Person
    {
        public int Id { get; set; }

        [StringLength(120, MinimumLength = 3)]
        [Required]
        [Display(Name = "Nome")]
        public string Name { get; set; } = string.Empty;

        [StringLength(120, MinimumLength = 3)]
        [Required]
        [Display(Name = "Endereço")]
        public string? Address { get; set; }

        [Required]
        [Display(Name = "Telefone")]
        [DataType(DataType.PhoneNumber)]
        public string? Phone { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        [Display(Name = "Criado Em")]
        [DataType(DataType.Date)]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Display(Name = "Atualizado Em")]
        [DataType(DataType.Date)]
        public DateTime? UpdatedAt { get; set; }
    }
}
