using CitySays.Application.ViewModels;

namespace CitySays.Application.Services.Arts
{
    public interface IArtService
    {
        public ValueTask<List<ArtsViewModel>> GetAllArtsWithFullInformationAsync();
    }
}
