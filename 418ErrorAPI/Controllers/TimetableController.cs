namespace _418ErrorAPI.Controllers;

using Microsoft.AspNetCore.Mvc;
using _418ErrorAPI.Models;


[ApiController]
[Route("[controller]")]
public class TimetableController : ControllerBase
{
    [HttpPut("actions/create")]
    public ActionResult<TimeTable> Put(string BusinessId, string UserId, string Name, string Conditions)
    {
        return Ok(
            new TimeTable
            {
                BusinessId = BusinessId,
                UserId = UserId,
                Name = Name,
                Conditions = Conditions
            });
    }

    [HttpPatch("{timetableId}/actions/update")]
    public ActionResult<TimeTable> patch(string Name, string Conditions)
    {
        return Ok(
            new TimeTable
            {
                Name = Name,
                Conditions = Conditions
            });
    }
}
