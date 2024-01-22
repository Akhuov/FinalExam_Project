using CitySays.Api.Dtos;
using CitySays.Api.ImgSaveService;
using CitySays.Application.Services.Arts;
using CitySays.Application.UseCases.Arts.Commands;
using CitySays.Application.UseCases.Arts.Querries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CitySays.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ArtsController : ControllerBase
    {
        private readonly ISavingService _savingService;
        private readonly IMediator _mediator;
        private readonly IArtService _artService;
        public ArtsController(IMediator mediator, ISavingService service, IArtService artService)
        {
            _mediator = mediator;
            _savingService = service;
            _artService = artService;
        }

        [HttpPost]

        public async ValueTask<IActionResult> CreateArtAsync([FromForm] ArtDto dto)
        {
            try
            {
                var command = new CreateArtCommand()
                {
                    UserId = dto.UserId,
                    City = dto.City,
                    ImageUrl = await _savingService.CreateAvatarAsync(dto.Image),
                    Name = dto.Name
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

        public async ValueTask<IActionResult> GetAllArtsAsync()
        {
            try
            {
                var res = await _mediator.Send(new GetAllArtsCommand());
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }


        [HttpGet]

        public async ValueTask<IActionResult> GetByIdArtAsync(int id)
        {
            try
            {
                var res = await _mediator.Send(new GetByIdArtCommand() { Id = id });
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }



        [HttpPut]

        public async ValueTask<IActionResult> UpdateArtAsync(int id, [FromForm] ArtDto dto)
        {
            try
            {
                var command = new UpdateArtCommand()
                {
                    Id = id,
                    City = dto.City,
                    UserId = dto.UserId,
                    ImageUrl = await _savingService.CreateAvatarAsync(dto.Image),
                    Name = dto.Name,
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
        public async ValueTask<IActionResult> DeleteArtAsync(int id)
        {
            try
            {
                var res = await _mediator.Send(new DeleteArtCommand() { Id = id });
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }


        [HttpGet]

        public async ValueTask<IActionResult> GetAllArtsWithFullInformationAsync()
        {
            try
            {
                var res = await _artService.GetAllArtsWithFullInformationAsync();
                return Ok(res);
            }
            catch (Exception ex)
            {
                return NotFound();
            }
        }
    }
}
