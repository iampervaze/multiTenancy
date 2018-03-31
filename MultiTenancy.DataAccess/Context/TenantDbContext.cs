using MultiTenancy.Core.Entities;
using System.Data.Entity;

namespace MultiTenancy.DataAccess.Context
{
    public class TenantDbContext : DbContext
    {
        public TenantDbContext(string connectionString) : base(connectionString)
        {
            Database.SetInitializer<TenantDbContext>(null);
        }

        public DbSet<Employee> Employees { get; set; }
    }
}