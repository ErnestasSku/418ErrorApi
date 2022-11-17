namespace _418ErrorAPI.Models;

public class Tax
{
    //PK
    public string TaxId { get; set; }
    //FK
    public string BusinessId { get; set; }
    //FK
    public string ProductId { get; set; }

    public string Type { get; set; }
    public string Conditions { get; set; }
}
