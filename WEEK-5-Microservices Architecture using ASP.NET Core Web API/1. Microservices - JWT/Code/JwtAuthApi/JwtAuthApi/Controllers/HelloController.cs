using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JwtAuthApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HelloController : ControllerBase
    {
        [HttpGet("secure")]
        [Authorize]
        public IActionResult GetSecureMessage()
        {
            return Ok("✅ You are authorized to access this protected resource.");
        }
    }
}
