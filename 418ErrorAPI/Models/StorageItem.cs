namespace _418ErrorAPI.Models;

public class StorageItem
{
    //pk
    public string StorageItemId { get; set; }
    //fk
    public string ItemId { get; set; }
    //fk
    public string StorageId { get; set; }

    public double Quantity { get; set; }
    public DateTime ReceiveDate { get; set; }
    public DateTime ExpirtationDate { get; set; }
    public double MinimumQuantity { get; set; }
}
