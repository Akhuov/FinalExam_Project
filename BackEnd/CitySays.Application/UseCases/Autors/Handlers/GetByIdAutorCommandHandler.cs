using CitySays.Application.Absreactions;
using CitySays.Application.UseCases.Autors.Querries;
using CitySays.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CitySays.Application.UseCases.Autors.Handlers
{
    public class GetByIdAutorCommandHandler : IRequestHandler<GetByIdAutorCommand, Autor>
    {
        private readonly IApplicationDbContext _applicationDbContext;

        public GetByIdAutorCommandHandler(IApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public async Task<Autor> Handle(GetByIdAutorCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var res = await _applicationDbContext.Autors.AsNoTracking().FirstOrDefaultAsync(x => x.Id == request.Id);
                return res;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
