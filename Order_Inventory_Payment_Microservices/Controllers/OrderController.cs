using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class OrderController : ControllerBase
{
    private static readonly List<string> Orders = new List<string>();

    [HttpGet]
    public IActionResult GetOrders()
    {
        return Ok(Orders);
    }

    [HttpPost]
    public IActionResult CreateOrder([FromBody] string order)
    {
        Orders.Add(order);
        return Ok(new { message = "Order created successfully" });
    }
}
