namespace _418ErrorAPI.Controllers;
using Microsoft.AspNetCore.Mvc;
using _418ErrorAPI.Models;


[ApiController]
[Route("[controller]")]
public class EmployeeController : ControllerBase
{
    [HttpPut("actions/create")]
    [ProducesResponseType(typeof(Employee), 200)]
    [ProducesResponseType(typeof(string), 400)]
    private ActionResult<Employee> Put(string RoleId, string BusinessId, string Details, string Name, string Surname, string Address, string Phone, string Email, string Password)
    {
        var newEmployee = 
            new Employee
            {
                EmployeeId = new Random().Next().ToString(),
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
        return Ok(newEmployee);
     }

    [HttpPut("{employeeId}/actions/assignRole/{roleId}")]
    public ActionResult<Employee> PutRole([FromRoute] string EmployeeId, [FromRoute] string RoleId)
    {
        //TODO: find the employee with Id,
        var employee = new Employee { EmployeeId = EmployeeId };
        employee.RoleId = RoleId;
        return Ok(employee);
    }

    [HttpDelete("{employeeId}/actions/delete")]
    public ActionResult Delete([FromRoute] string employeeId)
    {
        return Ok();
    }


}
