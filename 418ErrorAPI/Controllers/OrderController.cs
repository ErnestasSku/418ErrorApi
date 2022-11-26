namespace _418ErrorAPI.Controllers;

using _418ErrorAPI.Models;
using Microsoft.AspNetCore.Mvc;


[ApiController]
[Route("[controller]")]
public class OrderController: ControllerBase
{
    [HttpPatch("{oderId}/actions/applypromocode")]
    public ActionResult applyPromoCode([FromRoute] string orderId)
    {
        var order = new Order { OrderId = orderId };
        return Ok();
    }

    [HttpPatch("{orderId}/actions/refund")]
    public ActionResult<int> refund([FromRoute] string oderId)
    {
        var order = new Order { OrderId = oderId, Status = OrderStatus.Pending };
        return Ok(order.Status);
    }

    [HttpPatch("{orderId}/actions/gettips")]
    public ActionResult tips([FromRoute] string orderId)
    {
        var order = new Order { OrderId = orderId };
        return Ok();
    }

    [HttpPost("{orderId}/actions/addProduct/{productId}")]
    public ActionResult<IEnumerable<Product>> addProduct([FromRoute] string orderId, [FromRoute] string productId)
    {
        var order = new Order { OrderId = orderId };
        Product product = new Product { ProductId = productId };
    
        IEnumerable<Product> products = new List<Product> { product };
        return Ok(products);
        
    }

    [HttpPost("{orderId}/actions/update")]
    public ActionResult<Order> update([FromRoute ] string orderId, string SellerId, string PromoCodeId, DateTime Date, string Details, OrderStatus Status, string Dimmensions, string discountId)
    {
        var order = new Order
        {
            OrderId = orderId,
            SellerId = SellerId,
            PromoCodeId = PromoCodeId,
            Date = Date,
            Details = Details,
            Status = Status,
            DiscountId = discountId,
            Dimensions = Dimmensions
        };

        //TODO: OrderDTO, it should find existing order, update it and return a DTO. 
        return Ok(order);
    }

    [HttpPost("{orderId}/actions/applyDiscount/{discountId}")]
    [ProducesResponseType(typeof(List<Product>), 200)]
    [ProducesResponseType(typeof(string), 400)]
    [ProducesResponseType(typeof(string), 404)]
    public ActionResult<List<Product>> discount ([FromRoute] string orderId, [FromRoute] string discountId)
    {
        //Nothing much to write here without real database.
        List<Product> products = new List<Product>();
        return Ok(products);
    }


}
