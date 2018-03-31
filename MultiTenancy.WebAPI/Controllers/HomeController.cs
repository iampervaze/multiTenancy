using MultiTenancy.Core.Entities;
using MultiTenancy.DataAccess.Repository;
using System.Web.Http;

namespace MultiTenancy.WebAPI.Controllers
{
    public class HomeController : ApiController
    {
        private readonly IRepository<Employee> EmployeeRepository;

        public HomeController(IRepository<Employee> employeeRepository)
        {
            EmployeeRepository = employeeRepository;
        }

        public IHttpActionResult Get()
        {
            var response = EmployeeRepository.All();
            return Ok(response);
        }
    }
}