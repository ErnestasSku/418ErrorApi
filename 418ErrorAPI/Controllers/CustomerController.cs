namespace _418ErrorAPI.Controllers;

using Microsoft.AspNetCore.Mvc;
using _418ErrorAPI.Models;


[ApiController]
[Route("[controller]")]
public class CustomerController : ControllerBase
{
    [HttpPut("actions/create")]
    public ActionResult Put(string BusinessId, string Details, string Name, string Surname, string Address, string Phone, string Email, string Password)
    {
        var newCustomer = new Customer
        {
            BusinessId = BusinessId,
            Details = Details,
            Name = Name,
            Surname = Surname,
            Address = Address,
            Phone = Phone,
            Email = Email,
            Password = Password
        };
        return Ok();
    }

    //[ProducesResponseType(StatusCodes.Status200OK)]
    //[ProducesResponseType(StatusCodes.Status400BadRequest)]
    //[ProducesResponseType(StatusCodes.Status404NotFound)]
    //[ProducesResponseType(StatusCodes.Status500InternalServerError)]
    [HttpDelete("{userId}/actions/delete")]
    public IActionResult Delete([FromRoute] string userId)
    {
        return Ok();
    }
}
