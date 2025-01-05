using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JwtAuthApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenCheckController : ControllerBase
    {
        [HttpGet("Admin")]
        [Authorize(Roles = "Admin")]
        public IActionResult GreetAdminBasedOnToken()
        {
            return Ok("Hello Admin!");
        }

        [HttpGet("User")]
        [Authorize(Roles = "User")]
        public IActionResult GreetUserBasedOnToken()
        {
            return Ok("Hello User!");
        }
    }
}
