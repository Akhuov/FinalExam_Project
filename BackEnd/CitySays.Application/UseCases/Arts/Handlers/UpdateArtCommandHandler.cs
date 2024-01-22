using CitySays.Application.Absreactions;
using CitySays.Application.UseCases.Arts.Commands;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CitySays.Application.UseCases.Arts.Handlers
{
    public class UpdateArtCommandHandler : IRequestHandler<UpdateArtCommand, bool>
    {

        private readonly IApplicationDbContext _applicationDbContext;

        public UpdateArtCommandHandler(IApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public async Task<bool> Handle(UpdateArtCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var res = await _applicationDbContext.Arts.FirstOrDefaultAsync(x=>x.Id == request.Id);
                if (res != null)
                {
                    res.ImageUrl = request.ImageUrl;
                    res.Name = request.Name;
                    res.City = request.City;
                    res.UserId = request.UserId;


                    _applicationDbContext.Arts.Update(res);

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
