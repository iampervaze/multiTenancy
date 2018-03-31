using MultiTenancy.DataAccess.Factory;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiTenancy.DataAccess.Repository
{

    public interface IRepository<T> where T: class
    {

        IEnumerable<T> All();
    }

    public class Repository<T> : IRepository<T> where T : class
    {
        public DbContext _context;
        public Repository(IContextFactory contextFactory)
        {
            _context = contextFactory.GetContext();
        }

        public IEnumerable<T> All()
        {
            var query = _context.Set<T>();
            return query.ToList();
        }
    }
}
