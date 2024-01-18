using Microsoft.EntityFrameworkCore;

namespace CitySays.Application.Absreactions
{
    public interface IApplicationDbContext
    {

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
