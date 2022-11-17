namespace _418ErrorAPI.Models;


public class Refund
{
    //PK
    public string RefundId { get; set; }
    //Fk
    public string BusinessId { get; set; }
    //Fk
    public string OrderItemId { get; set; }

    public RefundStatus Status { get; set; }
    public DateTime Date { get; set; }
    public RefundType Type { get; set; }

}
