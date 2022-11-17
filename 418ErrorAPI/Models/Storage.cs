namespace _418ErrorAPI.Models;

public class Storage
{
    //pk
    public string StorageId { get; set; }
    //fk
    public string BusinessId { get; set; }

    public string Name { get; set; }
    public string Address { get; set; }
}
