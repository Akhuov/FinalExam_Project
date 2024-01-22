using MediatR;

namespace CitySays.Application.UseCases.Users.Commands
{
    public class UpdateUserCommand : IRequest<bool>
    {
        public int Id {  get; set; }
        public string NickName { get; set; }
        public string UserName { get; set; }
        public string Role { get; set; }
        public string Password { get; set; }
    }
}
