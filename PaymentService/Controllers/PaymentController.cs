using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class PaymentController : ControllerBase
{
    [HttpPost]
    public IActionResult ProcessPayment([FromBody] string orderId)
    {
        // Simple logic to simulate payment processing
        return Ok(new { message = $"Payment for Order {orderId} processed successfully" });
    }
}
