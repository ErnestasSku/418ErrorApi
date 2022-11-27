namespace _418ErrorAPI.Controllers;

using Microsoft.AspNetCore.Mvc;
using _418ErrorAPI.Models;


[ApiController]
[Route("[controller]")]
public class CustomerController : ControllerBase
{
    [HttpPut("actions/create")]
    [ProducesResponseType(typeof(Customer), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    public ActionResult<Customer> Put(string BusinessId, string Details, string Name, string Surname, string Address, string Phone, string Email, string Password)
    {
        var newCustomer = new Customer
        {
            UserId = new System.Random().Next().ToString(),
            BusinessId = BusinessId,
            Details = Details,
            Name = Name,
            Surname = Surname,
            Address = Address,
            Phone = Phone,
            Email = Email,
            Password = Password
        };
        return Ok(newCustomer);
    }

    [HttpDelete("{userId}/actions/delete")]
    [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
    public ActionResult Delete([FromRoute] string userId)
    {
        return Ok();
    }
}
