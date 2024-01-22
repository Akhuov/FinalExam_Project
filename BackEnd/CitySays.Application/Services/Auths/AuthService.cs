
using CitySays.Application.Absreactions;
using CitySays.Application.Services.JWT;
using CitySays.Application.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace CitySays.Application.Services.Auths
{
    public class AuthService : IAuthService
    {
        private readonly IApplicationDbContext _context;
        private readonly ITokenService _tokenService;

        public AuthService(IApplicationDbContext context, ITokenService tokenService)
        {
            _context = context;
            _tokenService = tokenService;
        }

        public async ValueTask<string> Login(UserCheckDto request)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.UserName == request.UserName);

            if (user is null)
            {
                throw new Exception("User not Found");
            }
            else if (user.Password != request.Password)
            {
                throw new Exception("Password is wrong!!");
            }
            return _tokenService.Generate(user.UserName);
        }
    }
}
