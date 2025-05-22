namespace MvcClient.Models
{
    public class Supplier : Person
    {
        public string CNPJ { get; set; } = string.Empty;

        public string? CompanyName { get; set; }

        public string? TradeName { get; set; }
    }
}
