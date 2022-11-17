namespace _418ErrorAPI.Models;

public class Discount
{
    //pk
    public string DisountId { get; set; }
    //fk
    public string BusinessId { get; set; }  

    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public DiscountType ValueType { get; set; }
    public double Value { get; set; }
}
