using CitySays.Application.ViewModels;

namespace CitySays.Application.Services.Auths
{
    public interface IAuthService
    {
        ValueTask<string> Login(UserCheckDto request);
    }
}
