using CitySays.Application.Absreactions;
using CitySays.Application.UseCases.Users.Commands;
using CitySays.Domain.Entities;
using MediatR;

namespace CitySays.Application.UseCases.Users.Handlers
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, bool>
    {
        private readonly IApplicationDbContext _applicationDbContext;

        public CreateUserCommandHandler(IApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public async Task<bool> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var newAutor = new User
                {
                    NickName = request.NickName,
                    Password = request.Password,
                    UserName = request.UserName,
                    Role = request.Role,
                };
                await _applicationDbContext.Users.AddAsync(newAutor);
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
