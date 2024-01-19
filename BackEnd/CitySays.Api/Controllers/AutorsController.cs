using CitySays.Api.Dtos;
using CitySays.Application.UseCases.Autors.Commands;
using CitySays.Application.UseCases.Autors.Querries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CitySays.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AutorsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public AutorsController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpPost]

        public async ValueTask<IActionResult> CreateAutorAsync(AutorDto dto)
        {
            try
            {
                var res = await _mediator.Send(new CreateAutorCommand{NickName=dto.NickName});
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
                var res = await _mediator.Send(new GetAllAutorsCommand());
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
                var res = await _mediator.Send(new GetByIdAutorCommand() { Id = id});
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut]

        public async ValueTask<IActionResult> UpdateAutorAsync(int id,AutorDto dto)
        {
            try
            {
                var res = await _mediator.Send(new UpdateAutorCommand() {NickName = dto.NickName,Id = id });
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
                var res = await _mediator.Send(new DeleteAutorCommand() { Id = id });
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

    }
}
