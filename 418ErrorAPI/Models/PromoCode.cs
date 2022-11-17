namespace _418ErrorAPI.Models;

public class PromoCode
{
    //PK
    public string PromoCodeId { get; set; }
    //FK
    public string BusinessId { get; set; }

    public string Code { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; } 
    
    public PromoCodeValueType Type { get; set; }
    public double Value { get; set; }
}
