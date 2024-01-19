using MediatR;

namespace CitySays.Application.UseCases.Autors.Commands
{
    public class CreateAutorCommand : IRequest<bool>
    {
        public string NickName { get; set; }
    }
}
