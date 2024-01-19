using MediatR;

namespace CitySays.Application.UseCases.Autors.Commands
{
    public class UpdateAutorCommand : IRequest<bool>
    {
        public int Id {  get; set; }
        public string NickName { get; set; }
    }
}
