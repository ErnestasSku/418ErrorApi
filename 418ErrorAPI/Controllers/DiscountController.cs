namespace _418ErrorAPI.Controllers;

using _418ErrorAPI.Models;
using Microsoft.AspNetCore.Mvc;


[ApiController]
[Route("[controller]")]
public class DiscountController : ControllerBase
{
    [HttpPut("actions/create")]
    public ActionResult<Discount> put(String BusinessId, DateTime StartDate, DateTime EndDate, DiscountType DiscountType, double Value) 
    {  
        var discount = new Discount
        {
            DisountId = new Random().Next().ToString(),
            BusinessId = BusinessId,
            StartDate = StartDate,
            EndDate = EndDate,
            ValueType = DiscountType,
            Value = Value
        };

        return Ok(discount);
    }

}
