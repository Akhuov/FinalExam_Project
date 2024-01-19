using CitySays.Domain.Entities;
using MediatR;

namespace CitySays.Application.UseCases.Autors.Querries
{
    public class GetAllAutorsCommand : IRequest<List<Autor>>
    {
    }
}
