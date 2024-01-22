using CitySays.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CitySays.Application.Absreactions
{
    public interface IApplicationDbContext
    {

        public DbSet<Art> Arts { get; set; }
        public DbSet<User> Users { get; set; }
        public Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
