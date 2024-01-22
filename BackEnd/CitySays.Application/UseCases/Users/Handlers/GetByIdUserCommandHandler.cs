using CitySays.Application.Absreactions;
using CitySays.Application.UseCases.Users.Querries;
using CitySays.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CitySays.Application.UseCases.Users.Handlers
{
    public class GetByIdUserCommandHandler : IRequestHandler<GetByIdUserCommand, User>
    {
        private readonly IApplicationDbContext _applicationDbContext;

        public GetByIdUserCommandHandler(IApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public async Task<User> Handle(GetByIdUserCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var res = await _applicationDbContext.Users.AsNoTracking().FirstOrDefaultAsync(x => x.Id == request.Id);
                return res;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
