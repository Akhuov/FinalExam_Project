using CitySays.Application.Absreactions;
using CitySays.Application.UseCases.Users.Querries;
using CitySays.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CitySays.Application.UseCases.Users.Handlers
{
    public class GetAllUsersCommandHandler : IRequestHandler<GetAllUsersCommand, List<User>>
    {

        private readonly IApplicationDbContext _applicationDbContext;

        public GetAllUsersCommandHandler(IApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public async Task<List<User>> Handle(GetAllUsersCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var res = await _applicationDbContext.Users.AsNoTracking().ToListAsync();

                return res;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
