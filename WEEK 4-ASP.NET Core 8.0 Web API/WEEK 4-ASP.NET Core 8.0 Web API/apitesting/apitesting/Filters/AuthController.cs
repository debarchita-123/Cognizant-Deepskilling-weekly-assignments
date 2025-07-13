using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace apitesting.Controllers // Replace `apitesting` with your actual namespace
{
    [ApiController]
    [Route("api/[controller]")]
    [AllowAnonymous] // This allows unauthenticated access to get a token
    public class AuthController : ControllerBase
    {
        private readonly string _securityKey = "mysuperdupersecretkey1234567890!@#"; // ✅ Same as in Program.cs

        [HttpGet("token")]
        public IActionResult GetToken()
        {
            var token = GenerateJSONWebToken(101, "Admin");
            return Ok(new { Token = token });
        }

        private string GenerateJSONWebToken(int userId, string userRole)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("mysuperdupersecret1234567890123456"));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new List<Claim>
    {
        new Claim(ClaimTypes.Role, userRole),
        new Claim("UserId", userId.ToString())
    };

            var token = new JwtSecurityToken(
                issuer: "mySystem",
                audience: "myUsers",
                claims: claims,
                expires: DateTime.Now.AddMinutes(2),  // Token expires in 2 mins
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

    }
}
