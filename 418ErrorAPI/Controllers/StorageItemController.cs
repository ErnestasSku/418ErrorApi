namespace _418ErrorAPI.Controllers;
using _418ErrorAPI.Models;
using Microsoft.AspNetCore.Mvc;


[ApiController]
[Route("[controller]")]
public class StorageItemController : ControllerBase
{
    [HttpPut("actions/create")]
    [ProducesResponseType(typeof(StorageItem), 200)]
    [ProducesResponseType(typeof(string), 400)]
    public ActionResult Put(string ProductId, string storageId, double Quantity, DateTime ReceiveDate, DateTime ExpirationDate, double MinimumQuantity)
    {
        var newStorageItem = new StorageItem
        {
            ItemId = ProductId,
            StorageId = storageId,
            Quantity = Quantity,
            ReceiveDate = ReceiveDate,
            ExpirtationDate = ExpirationDate,
            MinimumQuantity = MinimumQuantity
        };
        return Ok();
       
    }

    [HttpDelete("{storageItemId}/actions/delete")]
    [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(string), StatusCodes.Status403Forbidden)]
    [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(string), StatusCodes.Status500InternalServerError)]
    public IActionResult Delete([FromRoute] string storageItemId)
    {
        return Ok();
    }
}
