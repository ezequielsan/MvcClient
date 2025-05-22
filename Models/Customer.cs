using System.ComponentModel.DataAnnotations;

namespace MvcClient.Models
{
    public class Customer : Person
    {
        public string CPF { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        public DateTime? BirthDate { get; set; }
    }
}