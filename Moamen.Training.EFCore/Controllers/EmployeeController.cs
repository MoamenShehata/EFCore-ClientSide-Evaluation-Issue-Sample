using Microsoft.AspNetCore.Mvc;

namespace Moamen.Training.EFCore.Controllers
{
    [ApiController]
    [Route("api/employees")]
    public class EmployeeController : ControllerBase
    {
        private readonly DataContext dataContext;

        public EmployeeController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        [HttpGet]
        public IActionResult Get()
        {
            // As the documentation mentions that if we used unsupported evaluation (like evaluation that not at the projection) it should throw an exception BUT IT DID NOT
            var filtered = dataContext.Employees.Where(Predicate)
                .ToList();

            return Ok(filtered);
        }

        private bool Predicate(Moamen.Training.EFCore.Models.Employee employee)
        {
            return employee.Name.ToLower().StartsWith("a");
        }
    }
}
