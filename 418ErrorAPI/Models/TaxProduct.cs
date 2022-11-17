namespace _418ErrorAPI.Models;

public class TaxProduct
{
    //PK
    public string TaxProductId { get; set; }
    //FK
    public string TaxId { get; set; }
    //FK
    public string ProductId { get; set; }

    public string Type { get; set; } 
    public string Conditions { get; set; }
}
