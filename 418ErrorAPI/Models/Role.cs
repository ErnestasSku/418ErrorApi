namespace _418ErrorAPI.Models;

public class Role
{
    //PK
    public string RoleId { get; set; }
    //FK
    public string BusinessId { get; set; } 

    public string Title { get; set; }
    public string Description { get; set; }
}
