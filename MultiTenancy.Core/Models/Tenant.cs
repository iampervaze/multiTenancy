using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiTenancy.Core.Models
{
    public class Tenant
    {
        public int Id { get; set; }

        public Tenant(int id)
        {
            Id = id;
        }
    }
}
