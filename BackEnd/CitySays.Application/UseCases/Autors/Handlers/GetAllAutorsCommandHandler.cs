using CitySays.Application.Absreactions;
using CitySays.Application.UseCases.Arts.Querries;
using CitySays.Application.UseCases.Autors.Querries;
using CitySays.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CitySays.Application.UseCases.Autors.Handlers
{
    public class GetAllAutorsCommandHandler : IRequestHandler<GetAllAutorsCommand, List<Autor>>
    {

        private readonly IApplicationDbContext _applicationDbContext;

        public GetAllAutorsCommandHandler(IApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public async Task<List<Autor>> Handle(GetAllAutorsCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var res = await _applicationDbContext.Autors.AsNoTracking().ToListAsync();

                return res;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
