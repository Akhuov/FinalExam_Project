﻿using CitySays.Api.Dtos;
using CitySays.Api.ImgSaveService;
using CitySays.Application.UseCases.Arts.Commands;
using CitySays.Application.UseCases.Arts.Querries;
using CitySays.Application.UseCases.Autors.Commands;
using CitySays.Application.UseCases.Autors.Querries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CitySays.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ArtsController : ControllerBase
    { 
        private readonly ISavingService _savingService;
        private readonly IMediator _mediator;
        public ArtsController(IMediator mediator,ISavingService service)
        {
            _mediator = mediator;
            _savingService = service;
        }

        [HttpPost]

        public async ValueTask<IActionResult> CreateArtAsync([FromForm] ArtDto dto)
        {
            try
            {
                var command = new CreateArtCommand()
                {
                    AutorId = dto.AutorId,
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

        public async ValueTask<IActionResult> UpdateArtAsync(int id,[FromForm] ArtDto dto)
        {
            try
            {
                var command = new UpdateArtCommand()
                {
                    Id = id,
                    City = dto.City,
                    AutorId = dto.AutorId,
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
    }
}
