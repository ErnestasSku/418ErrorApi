namespace _418ErrorAPI.Controllers;

using _418ErrorAPI.Models;
using Microsoft.AspNetCore.Mvc;


[ApiController]
[Route("[controller]")]
public class RoleController: ControllerBase
{
    [HttpPut("actions/create")]
    public ActionResult Put(string BusinessId, string Title, string Description)
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
