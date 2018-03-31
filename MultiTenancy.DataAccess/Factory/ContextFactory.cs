using MultiTenancy.Core.Contracts;
using MultiTenancy.DataAccess.Context;
using System.Collections.Generic;
using System.Data.Entity;

namespace MultiTenancy.DataAccess.Factory
{
    public interface IContextFactory
    {
        DbContext GetContext();
    }

    public class ContextFactory : IContextFactory
    {
        private static Dictionary<int, string> ConnectionStrings = new Dictionary<int, string>()
            {
                {1, "Data Source=localhost; Database=tenant1; Integrated Security=True" },
                {2 , "Data Source=localhost; Database=tenant2; Integrated Security=True"}
            };

        private ITenantProvider _tenantProvider;

        public ContextFactory(ITenantProvider tenantProvider)
        {
            _tenantProvider = tenantProvider;
        }

        public DbContext GetContext()
        {
            var tenant = _tenantProvider.GetTenant();
            var connectionString = ConnectionStrings[tenant.Id];
            var context = new TenantDbContext(connectionString);
            return context;
        }
    }
}