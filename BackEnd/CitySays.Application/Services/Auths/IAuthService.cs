namespace CitySays.Application.Services.Auths
{
    public interface IAuthService
    {
        public ValueTask<string> GenerateToken(string username, string role);

    }
}
