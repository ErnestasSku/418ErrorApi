namespace _418ErrorAPI.Controllers;
using _418ErrorAPI.Models;
using Microsoft.AspNetCore.Mvc;


[ApiController]
[Route("[controller]")]
public class StorageItemController : ControllerBase
{
    //[ProducesResponseType(StatusCodes.Status200OK)]
    //[ProducesResponseType(StatusCodes.Status400BadRequest)]
    [HttpPut("actions/create")]
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

    //[ProducesResponseType(StatusCodes.Status200OK)]
    //[ProducesResponseType(StatusCodes.Status400BadRequest)]
    //[ProducesResponseType(StatusCodes.Status403Forbidden)]
    //[ProducesResponseType(StatusCodes.Status404NotFound)]
    //[ProducesResponseType(StatusCodes.Status500InternalServerError)]
    [HttpDelete("{storageItemId}/actions/delete")]
    public IActionResult Delete([FromRoute] string storageItemId)
    {
        return Ok();
    }
}
