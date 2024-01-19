using CitySays.Application.Absreactions;
using CitySays.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CitySays.Infrastructure.Persistance
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            //Database.Migrate();
        }

        public DbSet<Art> Arts { get; set; }
        public DbSet<Autor> Autors { get; set; }
    }
}
