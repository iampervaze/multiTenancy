using MultiTenancy.Black.Providers;
using MultiTenancy.Core.Common;
using MultiTenancy.Core.Contracts;
using MultiTenancy.DataAccess.Repository;
using StructureMap;

namespace MultiTenancy.Black
{
    public class IoC
    {
        public static void Init()
        {
            DI.Container = Container.For<MainRegistry>();
        }
    }

    public class MainRegistry : Registry
    {
        public MainRegistry()
        {
            Scan(scanner =>
            {
                scanner.TheCallingAssembly();
                scanner.AssembliesFromApplicationBaseDirectory();
                scanner.WithDefaultConventions();
            });

            For<ITenantProvider>().Use<ConsoleTenantProvider>();
            For(typeof(IRepository<>)).Use(typeof(Repository<>));
        }
    }
}