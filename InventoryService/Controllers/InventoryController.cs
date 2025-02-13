using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class InventoryController : ControllerBase
{
    private static readonly Dictionary<string, int> Inventory = new Dictionary<string, int>
    {
        { "Item1", 10 },
        { "Item2", 5 },
        { "Item3", 15 }
    };

    [HttpGet]
    public IActionResult GetInventory()
    {
        return Ok(Inventory);
    }

    [HttpPut("{item}")]
    public IActionResult UpdateInventory(string item, [FromBody] int quantity)
    {
        if (Inventory.ContainsKey(item))
        {
            Inventory[item] = quantity;
            return Ok(new { message = "Inventory updated" });
        }
        return NotFound(new { message = "Item not found" });
    }
}
