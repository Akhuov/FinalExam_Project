using MediatR;

namespace CitySays.Application.UseCases.Arts.Commands
{
    public class CreateArtCommand : IRequest<bool>
    {
        public int AutorId { get; set; }
        public string City { get; set; }
        public string Name { get; set; }
        public string? ImageUrl { get; set; }

    }
}
