using Microsoft.AspNetCore.Mvc;
using StockService = stocktracking.Services.Stock;

namespace stocktracking.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class StockController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] string? userId, [FromQuery] string? productId)
        {
            var body = await StockService.GetAllStock();
          
            return Ok(userId + "," + productId);
        } 
    }
}
