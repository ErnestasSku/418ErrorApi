namespace _418ErrorAPI.Models;

public class Order
{
    //pk
    public string OrderId { get; set; }
    //fk
    public string BusinessId { get; set; }
    //fk
    public string BuyerId { get; set; }
    //fk
    public string SellerId { get; set; }
    //fk
    public string PromoCodeId { get; set; }

    public DateTime Date { get; set; }
    public string Details { get; set; }
    public OrderStatus Status { get; set; }
    public string PaymentMethod { get; set; }
    public decimal Tips { get; set; }
    public string Dimensions { get; set; }
    //TODO: note, thete might be a mistake in the data model. This should be foreign key as well
    public string DiscountId { get; set; }
}
