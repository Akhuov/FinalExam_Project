using CitySays.Domain.Entities;
using MediatR;

namespace CitySays.Application.UseCases.Users.Querries
{
    public class GetAllUsersCommand : IRequest<List<User>>
    {
    }
}
