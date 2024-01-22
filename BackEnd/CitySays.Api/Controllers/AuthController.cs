using CitySays.Application.Services.Auths;
using CitySays.Application.UseCases.Users.Querries;
using CitySays.Domain.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CitySays.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        //private readonly IMediator _mediator;
        //private readonly IAuthService _authService;

        //public AuthController(IMediator mediator, IAuthService authService)
        //{
        //    _mediator = mediator;
        //    _authService = authService;
        //}

        //[HttpPost]
        //public async ValueTask<IActionResult> Login(LoginRequest loginRequest)
        //{
        //    var user = _mediator.Send(new GetAllUsersCommand())
        //        .Result
        //        .FirstOrDefault(x => x.UserName == loginRequest.UserName && x.Password == loginRequest.Password);

        //    if (user == null)
        //    {
        //        return NotFound("Login yoki parol hato");
        //    }

        //    string token = await _authService.GenerateToken(loginRequest.UserName, user.Role);

        //    return Ok(token);
        //}
    }
}
