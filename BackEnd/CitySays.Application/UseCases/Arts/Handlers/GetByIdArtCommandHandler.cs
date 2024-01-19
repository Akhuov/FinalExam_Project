using CitySays.Application.Absreactions;
using CitySays.Application.UseCases.Arts.Querries;
using CitySays.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CitySays.Application.UseCases.Arts.Handles
{
    public class GetByIdArtCommandHandler : IRequestHandler<GetByIdArtCommand, Art>
    {

        private readonly IApplicationDbContext _applicationDbContext;

        public GetByIdArtCommandHandler(IApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<Art> Handle(GetByIdArtCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var res = await _applicationDbContext.Arts.FirstOrDefaultAsync(x=>x.Id == request.Id);
                return res;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
