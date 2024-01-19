using CitySays.Domain.Entities;
using MediatR;

namespace CitySays.Application.UseCases.Arts.Querries
{
    public class GetByIdArtCommand : IRequest<Art>
    {
        public int Id { get; set; } 
    }
}
