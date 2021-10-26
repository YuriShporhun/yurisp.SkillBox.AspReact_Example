using Application.Interfaces;
using Domain;
using Infrastructure.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Persistence
{
    public class DataContext : IdentityDbContext<ApplicationUser>, IDataAccess
    {
        public DataContext()
        {

        }

        public DataContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public async Task<int> SaveAsync(CancellationToken cancellationToken)
        {
            return await SaveChangesAsync(cancellationToken);
        }

        public DbSet<Ticket> Tickets { get; set; }
    }
}
