using CitySays.Application.Absreactions;
using CitySays.Application.UseCases.Users.Commands;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CitySays.Application.UseCases.Users.Handlers
{
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, bool>
    {
        private readonly IApplicationDbContext _applicationDbContext;

        public UpdateUserCommandHandler(IApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<bool> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var res = await _applicationDbContext.Users.FirstOrDefaultAsync(x => x.Id == request.Id);
                if (res !=null)
                {
                    res.NickName = request.NickName;
                    res.UserName = request.UserName;
                    res.Role = request.Role;
                    res.Password = request.Password;


                    _applicationDbContext.Users.Update(res);
                    await _applicationDbContext.SaveChangesAsync(cancellationToken);
                    return true;
                }
                throw new Exception("Autor Not Found!");
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
