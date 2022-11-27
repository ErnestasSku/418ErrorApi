namespace _418ErrorAPI.Controllers;

using _418ErrorAPI.Models;
using Microsoft.AspNetCore.Mvc;


[ApiController]
[Route("[controller]")]
public class ProductController: ControllerBase
{
    [HttpPost("{productId}/actions/applyDiscount/{discountId}")]
    [ProducesResponseType(typeof(List<Discount>), 200)]
    [ProducesResponseType(typeof(string), 404)]
    public ActionResult applyDiscount([FromRoute] string productId, [FromRoute] string discountId)
    {
        return Ok();
    }

    [HttpPost("{productId}/actions/removeDiscount/{discountId}")]
    [ProducesResponseType(typeof(List<Discount>), 200)]
    [ProducesResponseType(typeof(string), 400)]
    [ProducesResponseType(typeof(string), 404)]
    public ActionResult removeDiscount([FromRoute] string productId, [FromRoute] string discountId)
    {
        return Ok();
    }

    [HttpPost("{productId}/actions/removeDiscount")]
    [ProducesResponseType(typeof(List<Tax>), 200)]
    [ProducesResponseType(typeof(string), 400)]
    [ProducesResponseType(typeof(string), 404)]
    public ActionResult applyTax([FromRoute] string productId, List<Tax> taxes)
    {
        return Ok();
    }

    [HttpPost("{productId}/actions/update")]
    [ProducesResponseType(typeof(Product), 200)]
    [ProducesResponseType(typeof(string), 400)]
    [ProducesResponseType(typeof(string), 404)]
    public ActionResult<Product> updateProduct([FromRoute] string productId, string discountId, string name, string type, decimal price, ProductQuantityType productQuantityType, double quantity, string description, string weight)
    {
        return Ok();
    }


}
