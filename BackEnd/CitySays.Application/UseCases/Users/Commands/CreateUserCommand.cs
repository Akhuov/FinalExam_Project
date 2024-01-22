using MediatR;

namespace CitySays.Application.UseCases.Users.Commands
{
    public class CreateUserCommand : IRequest<bool>
    {
        public string NickName { get; set; }
        public string UserName { get; set; }
        public string Role { get; set; }
        public string Password { get; set; }
    }
}
