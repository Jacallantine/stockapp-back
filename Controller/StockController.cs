using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using stocktracking.Models;
using StockService = stocktracking.Services.Stock;

namespace stocktracking.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class StockController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            await StockService.GetAllStock();
            return Ok();
        }
    }
}
