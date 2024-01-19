using CitySays.Domain.Entities;
using MediatR;

namespace CitySays.Application.UseCases.Autors.Querries
{
    public class GetByIdAutorCommand : IRequest<Autor>
    {
        public int Id { get; set; }
    }
}
