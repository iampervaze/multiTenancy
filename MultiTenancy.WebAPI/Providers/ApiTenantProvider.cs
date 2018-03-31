using MultiTenancy.Core.Contracts;
using MultiTenancy.Core.Models;
using System;

namespace MultiTenancy.WebAPI.Providers
{
    public class ApiTenantProvider : ITenantProvider
    {
        public Tenant GetTenant()
        {
            return new Tenant(1);
        }
    }
}