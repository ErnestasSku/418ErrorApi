namespace _418ErrorAPI.Controllers;

using _418ErrorAPI.Models;
using Microsoft.AspNetCore.Mvc;


[ApiController]
[Route("[controller]")]
public class PromoCodeController: ControllerBase
{
    [HttpPut("actions/create")]
    [ProducesResponseType(typeof(PromoCode), 200)]
    [ProducesResponseType(typeof(string), 400)]
    [ProducesResponseType(typeof(string), 404)]
    public ActionResult<List<PromoCode>> createPromoCode(string businessId, string code, DateTime dateTime, DateTime dentDate, PromoCodeValueType promoCodeValueType, double value)
    {
        return Ok();
    }

    [HttpPost("{PromoCodeId}/actions/delete")]
    public ActionResult deletePromoCode([FromRoute] string PromoCOdeId)
    {
        return Ok();
    }
}
