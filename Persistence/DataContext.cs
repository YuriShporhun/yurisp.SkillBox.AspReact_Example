using Application.Persistence.Interfaces;
using Domain;
using Entities.Domain;
using Infrastructure.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Persistence
{
    public class DataContext : IdentityDbContext<ApplicationUser>, IDataAccess
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
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

        public DbSet<Trip> Tickets { get; set; }
        public DbSet<DestinationImage> DestinationImages { get; set; }
    }
}
