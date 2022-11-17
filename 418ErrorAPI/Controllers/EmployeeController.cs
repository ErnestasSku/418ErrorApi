namespace _418ErrorAPI.Controllers;
using Microsoft.AspNetCore.Mvc;
using _418ErrorAPI.Models;


[ApiController]
[Route("[controller]")]
public class EmployeeController : ControllerBase
{
    [HttpPut("actions/create")]
    private void Put(string RoleId, string BusinessId, string Details, string Name, string Surname, string Address, string Phone, string Email, string Password)
    {
        var newEmployee = 
            new Employee
            {
                RoleId = RoleId,
                BusinessId = BusinessId,
                Details = Details,
                Name = Name,
                Surname = Surname,
                Address = Address,
                Phone = Phone,
                Email = Email,
                Password = Password
            };
     }

    [HttpPut("{employeeId}/actions/assignRole/{roleId}")]
    public ActionResult PutRole([FromRoute] string EmployeeId, [FromRoute] string RoleId)
    {
        //TODO: find the employee with Id,
        var employee = new Employee { EmployeeId = EmployeeId };
        employee.RoleId = RoleId;
        return Ok();
    }

    //[ProducesResponseType(StatusCodes.Status200OK)]
    //[ProducesResponseType(StatusCodes.Status404NotFound)]
    [HttpDelete("{employeeId}/actions/delete")]
    public IActionResult Delete([FromRoute] string employeeId)
    {
        return Ok();
    }


}
