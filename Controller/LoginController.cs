using Microsoft.AspNetCore.Mvc;
using stocktracking.Models.Dto;

namespace stocktracking.Controller
{

    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Login([FromBody] Login login)
        {
            return Ok(Login);
        }
    }
}
