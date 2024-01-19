using CitySays.Domain.Entities;
using MediatR;

namespace CitySays.Application.UseCases.Arts.Querries
{
    public class GetAllArtsCommand : IRequest<List<Art>>
    {
    }
}
