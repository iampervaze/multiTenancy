using MultiTenancy.Core.Contracts;
using MultiTenancy.Core.Models;
using System;

namespace MultiTenancy.Black.Providers
{
    public class ConsoleTenantProvider : ITenantProvider
    {
        public Tenant GetTenant()
        {
            Console.Write("Enter Tenant Id : ");
            string tenantString = Console.ReadLine();
            int tenantId = int.Parse(tenantString);
            return new Tenant(tenantId);
        }
    }
}