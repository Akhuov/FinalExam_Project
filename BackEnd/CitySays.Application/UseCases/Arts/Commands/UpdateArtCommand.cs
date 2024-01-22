﻿using MediatR;

namespace CitySays.Application.UseCases.Arts.Commands
{
    public class UpdateArtCommand : IRequest<bool>
    {
        public int Id { get; set; }


        public int UserId { get; set; }
        public string Inform { get; set; }
        public string City { get; set; }
        public string Name { get; set; }
        public string? ImageUrl { get; set; }
    }
}
