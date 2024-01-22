using CitySays.Application.Absreactions;
using CitySays.Application.UseCases.Arts.Commands;
using CitySays.Domain.Entities;
using MediatR;

namespace CitySays.Application.UseCases.Arts.Handles
{
    public class CreateArtCommandHandler : IRequestHandler<CreateArtCommand, bool>
    {
        private readonly IApplicationDbContext _applicationDbContext;

        public CreateArtCommandHandler(IApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public async Task<bool> Handle(CreateArtCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var newArt = new Art
                {
                    Name = request.Name,
                    UserId = request.UserId,
                    City = request.City,
                    ImageUrl = request.ImageUrl,
                    Inform = request.inform,
                };


                await _applicationDbContext.Arts.AddAsync(newArt);
                await _applicationDbContext.SaveChangesAsync(cancellationToken);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
