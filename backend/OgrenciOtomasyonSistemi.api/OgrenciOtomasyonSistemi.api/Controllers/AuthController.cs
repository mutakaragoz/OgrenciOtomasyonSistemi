namespace OgrenciOtomasyonSistemi.api.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using OgrenciOtomasyonSistemi.Shared.DTOs;
    using OgrenciOtomasyonSistemi.api.Services;
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly AuthService _authService;

        public AuthController(AuthService authService) => _authService = authService;

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterDto model)
        {
            var result = await _authService.RegisterUserAsync(model.email, model.password, model.role);
            if (!result.Succeeded) return BadRequest(result.Errors);
            return Ok(new { Message = "Kayıt başarılı" });
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDto model)
        {
            var token = await _authService.LoginUserAsync(model.email, model.password);
            if (token == null) return Unauthorized("Kullanıcı adı veya parola hatalı.");
            return Ok(new { Token = token });
        }
    }
}
