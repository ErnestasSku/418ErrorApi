namespace _418ErrorAPI.Controllers;
using _418ErrorAPI.Models;
using Microsoft.AspNetCore.Mvc;


[ApiController]
[Route("[controller]")]
public class UserLoyaltyController: ControllerBase
{
    [HttpPut("actions/crate")]
    [ProducesResponseType(typeof(UserLoyalty), 200)]
    [ProducesResponseType(typeof(string), 400)]
    public ActionResult<UserLoyalty> createUserLoyalty(string userId, string loyaltyId, DateTime startDate, DateTime endDate)
    {
        return Ok();
    }
}
