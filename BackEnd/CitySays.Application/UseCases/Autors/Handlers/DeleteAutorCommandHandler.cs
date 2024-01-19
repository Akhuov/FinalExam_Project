using CitySays.Application.Absreactions;
using CitySays.Application.UseCases.Autors.Commands;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CitySays.Application.UseCases.Autors.Handlers
{
    public class DeleteAutorCommandHandler : IRequestHandler<DeleteAutorCommand, bool>
    {
        private readonly IApplicationDbContext _applicationDbContext;

        public DeleteAutorCommandHandler(IApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<bool> Handle(DeleteAutorCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var res = await _applicationDbContext.Autors.FirstOrDefaultAsync(x=>x.Id== request.Id);

                if (res!=null)
                {
                    _applicationDbContext.Autors.Remove(res);   
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
