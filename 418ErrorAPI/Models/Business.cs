namespace _418ErrorAPI.Models;

using Microsoft.AspNetCore.Mvc;
using System.Runtime.Serialization;

[DataContract]
public class Business
{
    //PK
    public string BusinessId { get; set; }
    public string Details { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
}
