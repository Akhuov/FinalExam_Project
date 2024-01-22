using CitySays.Domain.Entities;
using MediatR;

namespace CitySays.Application.UseCases.Users.Querries
{
    public class GetByIdUserCommand : IRequest<User>
    {
        public int Id { get; set; }
    }
}
