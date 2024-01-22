using CitySays.Application.Absreactions;
using CitySays.Application.UseCases.Users.Commands;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CitySays.Application.UseCases.Users.Handlers
{
    public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand, bool>
    {
        private readonly IApplicationDbContext _applicationDbContext;

        public DeleteUserCommandHandler(IApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<bool> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var res = await _applicationDbContext.Users.FirstOrDefaultAsync(x=>x.Id== request.Id);

                if (res!=null)
                {
                    _applicationDbContext.Users.Remove(res);   
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
