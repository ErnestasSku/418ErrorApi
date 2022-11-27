namespace _418ErrorAPI.Controllers;

using _418ErrorAPI.Models;
using Microsoft.AspNetCore.Mvc;


[ApiController]
[Route("[controller]")]
public class TaxController: ControllerBase
{
    [HttpPut("actions/create")]
    [ProducesResponseType(typeof(Tax), 200)]
    [ProducesResponseType(typeof(string), 400)]
    public ActionResult<Tax> createTax(string businessId, string productId, string type, string conditions)
    {
        return Ok();
    }
}
