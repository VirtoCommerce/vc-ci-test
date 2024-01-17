using EntityFrameworkCore.Triggers;
using Microsoft.EntityFrameworkCore;

namespace VirtoCommerce.CITest.Data.Repositories
{
    public class CITestDbContext : DbContextWithTriggers
    {
        public CITestDbContext(DbContextOptions<CITestDbContext> options)
            : base(options)
        {
        }

        protected CITestDbContext(DbContextOptions options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
