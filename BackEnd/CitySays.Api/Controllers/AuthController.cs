using CitySays.Application.Services.Auths;
using CitySays.Application.ViewModels;
using CitySays.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CitySays.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        private readonly ILogger<AuthController> _logger;

        public AuthController(IAuthService authService, ILogger<AuthController> logger)
        {
            _authService = authService;
            _logger = logger;

        }

        [HttpPost]
        public async ValueTask<IActionResult> Login(UserCheckDto request)
        {
            try
            {
                var token = await _authService.Login(request);

                return Ok(token);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex.StackTrace);
                return BadRequest("Username or Password is not valid");
            }
        }
    }
}
