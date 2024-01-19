using MediatR;

namespace CitySays.Application.UseCases.Arts.Commands
{
    public class DeleteArtCommand : IRequest<bool>
    {
        public int Id { get; set; }

    }
}
