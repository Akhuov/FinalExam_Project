using MediatR;

namespace CitySays.Application.UseCases.Autors.Commands
{
    public class DeleteAutorCommand : IRequest<bool>
    {
        public int Id { set; get; }

    }
}
