using CitySays.Application.Absreactions;
using CitySays.Application.UseCases.Autors.Commands;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CitySays.Application.UseCases.Autors.Handlers
{
    public class UpdateAutorCommandHandler : IRequestHandler<UpdateAutorCommand, bool>
    {
        private readonly IApplicationDbContext _applicationDbContext;

        public UpdateAutorCommandHandler(IApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<bool> Handle(UpdateAutorCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var res = await _applicationDbContext.Autors.FirstOrDefaultAsync(x => x.Id == request.Id);
                if (res !=null)
                {
                    res.NickName = request.NickName;
                    _applicationDbContext.Autors.Update(res);
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
