namespace _418ErrorAPI.Controllers;

using _418ErrorAPI.Models;
using Microsoft.AspNetCore.Mvc;


[ApiController]
[Route("[controller]")]
public class OrderController : ControllerBase
{
    [HttpPatch("{orderId}/actions/applypromocode")]
    public ActionResult applyPromoCode([FromRoute] string orderId)
    {
        var order = new Order { OrderId = orderId };
        return Ok();
    }

    [HttpPatch("{orderId}/actions/refund")]
    [ProducesResponseType(typeof(int), 200)]
    [ProducesResponseType(typeof(string), 400)]
    [ProducesResponseType(typeof(string), 404)]
    public ActionResult<int> refund([FromRoute] string orderId)
    {
        var order = new Order { OrderId = orderId, Status = OrderStatus.Pending };
        return Ok(order.Status);
    }

    [HttpPatch("{orderId}/actions/gettips")]
    public ActionResult tips([FromRoute] string orderId)
    {
        var order = new Order { OrderId = orderId };
        return Ok();
    }

    [HttpPost("{orderId}/actions/addProduct/{productId}")]
    [ProducesResponseType(typeof(List<Product>), 200)]
    [ProducesResponseType(typeof(string), 400)]
    [ProducesResponseType(typeof(string), 404)]
    public ActionResult<IEnumerable<Product>> addProduct([FromRoute] string orderId, [FromRoute] string productId)
    {
        var order = new Order { OrderId = orderId };
        Product product = new Product { ProductId = productId };

        IEnumerable<Product> products = new List<Product> { product };
        return Ok(products);

    }

    [HttpPost("{orderId}/actions/update")]
    [ProducesResponseType(typeof(Order), 200)]
    [ProducesResponseType(typeof(string), 400)]
    [ProducesResponseType(typeof(string), 404)]
    public ActionResult<Order> update([FromRoute] string orderId, string SellerId, string PromoCodeId, DateTime Date, string Details, OrderStatus Status, string Dimmensions, string discountId)
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
    public ActionResult<List<Product>> discount([FromRoute] string orderId, [FromRoute] string discountId)
    {
        List<Product> products = new List<Product>();
        return Ok(products);
    }

    [HttpPost("{orderId}/actions/removeDiscount/{discountId}")]
    [ProducesResponseType(typeof(List<Product>), 200)]
    [ProducesResponseType(typeof(string), 400)]
    [ProducesResponseType(typeof(string), 404)]
    public ActionResult<List<Product>> removeDiscount([FromRoute] string orderId, [FromRoute] string discountId)
    {
        return Ok();
    }

    [HttpPost("{orderId}/actions/changeStatus/awaitingPayment")]
    [ProducesResponseType(typeof(Order), 200)]
    [ProducesResponseType(typeof(string), 400)]
    [ProducesResponseType(typeof(string), 404)]
    public ActionResult<Order> changeStatus([FromRoute] string orderId)
    {
        return Ok();
    }

    [HttpPost("{orderId}/actions/setPaymentMethod/{paymentMethod}")]
    [ProducesResponseType(typeof(string), 200)]
    [ProducesResponseType(typeof(string), 400)]
    [ProducesResponseType(typeof(string), 404)]
    public ActionResult<string> setPaymentMethod([FromRoute] string orderId, [FromRoute] string paymentMethod)
    {
        return Ok();
    }

    [HttpPost("{orderId}/actions/deleteProduct/{orderItemId}")]
    public ActionResult deleteProduct([FromRoute] string orderId, [FromRoute] string orderItemId)
    {
        return Ok();
    }


    /// order/{orderId}/actions/setPaymentMethod/cash
    /// order/{orderId}/actions/setPaymentMethod/card 
    /// /order/{orderId}/actions/changeStatus/CancelledByCustomer 
}
