namespace _418ErrorAPI.Models;


public class Loyalty
{
    //PK
    public string LoyaltyId { get; set; }
    //FK
    public string BusinessId { get; set; }

    public string Description { get; set; }
    public DateTime Length { get; set; }
    public decimal Price { get; set; }
    public DateTime ExpirationDate { get; set; }
    public LoyaltyType Type { get; set; }

}
