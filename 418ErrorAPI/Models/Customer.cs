namespace _418ErrorAPI.Models;

public class Customer
{
    //PK
    public string UserId { get; set; }
    //FK
    public string BusinessId { get; set; }

    public string Details { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

}
