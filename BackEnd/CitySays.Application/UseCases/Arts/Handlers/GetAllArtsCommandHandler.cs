using CitySays.Application.Absreactions;
using CitySays.Application.UseCases.Arts.Querries;
using CitySays.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CitySays.Application.UseCases.Arts.Handles
{
    public class GetAllArtsCommandHandler : IRequestHandler<GetAllArtsCommand, List<Art>>
    {

        private readonly IApplicationDbContext _applicationDbContext;

        public GetAllArtsCommandHandler(IApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<List<Art>> Handle(GetAllArtsCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var res = await _applicationDbContext.Arts.AsNoTracking().ToListAsync();
                return res;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
