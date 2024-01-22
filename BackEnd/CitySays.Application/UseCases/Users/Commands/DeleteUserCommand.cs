using MediatR;

namespace CitySays.Application.UseCases.Users.Commands
{
    public class DeleteUserCommand : IRequest<bool>
    {
        public int Id { set; get; }

    }
}
