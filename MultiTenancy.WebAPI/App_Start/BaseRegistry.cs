using MultiTenancy.Core.Contracts;
using MultiTenancy.DataAccess.Repository;
using MultiTenancy.WebAPI.Providers;
using StructureMap;
using StructureMap.Graph;
using System;

namespace MultiTenancy.WebAPI.App_Start
{
    public class BaseRegistry : Registry
    {
        public BaseRegistry()
        {
            Scan(s =>
            {
                s.AssembliesFromApplicationBaseDirectory(a => a.FullName.StartsWith("MultiTenancy", StringComparison.InvariantCultureIgnoreCase));
                s.SingleImplementationsOfInterface();
                s.LookForRegistries();
                s.WithDefaultConventions();
            });

            For<ITenantProvider>().Use<ApiTenantProvider>();
            For(typeof(IRepository<>)).Use(typeof(Repository<>));
        }
    }
}