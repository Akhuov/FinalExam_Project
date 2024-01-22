using CitySays.Application.Absreactions;
using CitySays.Application.ViewModels;
using CitySays.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CitySays.Application.Services.Arts
{
    public class ArtService: IArtService
    {
        private readonly IApplicationDbContext _applicationDbContext;

        public ArtService(IApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async ValueTask<List<ArtsViewModel>> GetAllArtsWithFullInformationAsync()
        {
            try
            {
                List<Art> res = await _applicationDbContext.Arts.Include(x => x.User).AsNoTracking().ToListAsync();
                var list = new List<ArtsViewModel>();
                foreach (var arts in res)
                {
                    list.Add(new ArtsViewModel { 
                        ArtInform = arts.Inform,
                        ArtCity = arts.City,
                        ArtName = arts.Name,
                        AutorNickName = arts.User.NickName,
                        ImageUrl = arts.ImageUrl,
                    });
                }

                return list;

            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
