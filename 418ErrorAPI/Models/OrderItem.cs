namespace _418ErrorAPI.Models;

public class OrderItem
{
    //pk
    public string OrderItemId { get; set; }
    //fk
    public string ProductId { get; set; }
    //fk
    public string OrderId { get; set; }

    public int Quantity { get; set; }
    public double Weight { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }


}
