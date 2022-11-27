namespace _418ErrorAPI.Controllers;

using Microsoft.AspNetCore.Mvc;
using _418ErrorAPI.Models;


[ApiController]
[Route("[controller]")]
public class TimetableController : ControllerBase
{
    [HttpPut("actions/create")]
    [ProducesResponseType(typeof(TimeTable), 200)]
    [ProducesResponseType(typeof(string), 400)]
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
    [ProducesResponseType(typeof(TimeTable), 200)]
    [ProducesResponseType(typeof(string), 400)]
    [ProducesResponseType(typeof(string), 404)]
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
