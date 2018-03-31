using MultiTenancy.Core.Models;

namespace MultiTenancy.Core.Contracts
{
    public interface ITenantProvider
    {
        Tenant GetTenant();
    }
}