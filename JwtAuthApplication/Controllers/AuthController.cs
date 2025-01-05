using JwtAuthApplication.Data;
using JwtAuthApplication.Models;
using JwtAuthApplication.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JwtAuthApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly TokenService _tokenService;
        private readonly ApplicationDbContext _context;
        public AuthController(ApplicationDbContext context, TokenService tokenService)
        {
            _tokenService = tokenService;
            _context = context;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] loginDto loginRequest)
        {
            try
            {
                var user = await _context.Users.FirstOrDefaultAsync(u=>u.userName==loginRequest.userName && u.Password == loginRequest.Password);
                if (user == null) {
                    return Unauthorized("Invalid credentials");
                }
                var token = _tokenService.generateToken(user);
                return Ok(new { Token = token });
            }
            catch
            {
                throw;
            }
        }
    }
}
