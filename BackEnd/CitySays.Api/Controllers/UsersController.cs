using CitySays.Api.Dtos;
using CitySays.Application.UseCases.Users.Commands;
using CitySays.Application.UseCases.Users.Querries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CitySays.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IMediator _mediator;
        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpPost]

        public async ValueTask<IActionResult> CreateAutorAsync(UserDto dto)
        {
            try
            {
                var command = new CreateUserCommand
                {
                    NickName = dto.NickName,
                    Password = dto.Password,
                    UserName = dto.UserName,
                };

                var res = await _mediator.Send(command);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet]

        public async ValueTask<IActionResult> GetAllAutorsAsync()
        {
            try
            {
                var res = await _mediator.Send(new GetAllUsersCommand());
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet]

        public async ValueTask<IActionResult> GetByIdAutorAsync(int id)
        {
            try
            {
                var res = await _mediator.Send(new GetByIdUserCommand() { Id = id });
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut]

        public async ValueTask<IActionResult> UpdateAutorAsync(int id, UserDto dto)
        {
            try
            {
                var command = new UpdateUserCommand() 
                { 
                    Id = id,
                    NickName = dto.NickName,
                    Password = dto.Password,
                    UserName = dto.UserName,
                };
                var res = await _mediator.Send(command);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }


        [HttpDelete]
        public async ValueTask<IActionResult> DeleteAutorAsync(int id)
        {
            try
            {
                var res = await _mediator.Send(new DeleteUserCommand() { Id = id });
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

    }
}
