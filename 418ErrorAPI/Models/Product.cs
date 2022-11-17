namespace _418ErrorAPI.Models;

public class Product
{
    //pk
    public string ProductId { get; set; }
    //fk
    public string DiscountId { get; set; }
    //fk
    public string BusinessId { get; set; }

    public string Name { get; set; }
    public string Type { get; set; }
    public decimal Price { get; set; }
    public ProductQuantityType QuantityType {get; set;}
    public double Quantity { get; set; }
    public string Description { get; set; }
    public double Weight { get; set; }

}
