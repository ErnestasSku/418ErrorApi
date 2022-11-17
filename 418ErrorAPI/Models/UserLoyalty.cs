namespace _418ErrorAPI.Models;

public class UserLoyalty
{
    //Pk
    public int UserLoyaltyId { get; set; }
    //Fk
    public string UserId { get; set; }
    //FK
    public string LoyaltyId { get; set; }

    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}
