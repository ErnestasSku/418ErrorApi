namespace _418ErrorAPI.Controllers;

using _418ErrorAPI.Models;
using Microsoft.AspNetCore.Mvc;


[ApiController]
[Route("[controller]")]
public class RoleController: ControllerBase
{
    [HttpPut("actions/create")]
    [ProducesResponseType(typeof(Role), 200)]
    [ProducesResponseType(typeof(string), 400)]
    [ProducesResponseType(typeof(string), 404)]
    public ActionResult<Role> Put(string BusinessId, string Title, string Description)
    {
        var newRole = new Role { BusinessId = BusinessId, Title = Title, Description = Description };
        return Ok();
    }

    [HttpDelete("{roleId}/actions/delete")]
    public ActionResult Delete()
    {
        return Ok();
    }
}
