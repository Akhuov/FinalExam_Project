using CitySays.Application.Absreactions;
using CitySays.Application.UseCases.Arts.Commands;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CitySays.Application.UseCases.Arts.Handlers
{
    public class DeleteArtCommandHandler : IRequestHandler<DeleteArtCommand, bool>
    {
        private readonly IApplicationDbContext _applicationDbContext;

        public DeleteArtCommandHandler(IApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<bool> Handle(DeleteArtCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var res = await _applicationDbContext.Arts.FirstOrDefaultAsync(x => x.Id == request.Id);
                if (res != null)
                {
                    _applicationDbContext.Arts.Remove(res);
                    await _applicationDbContext.SaveChangesAsync(cancellationToken);
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
