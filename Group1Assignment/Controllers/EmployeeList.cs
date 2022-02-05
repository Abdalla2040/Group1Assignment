using Microsoft.AspNetCore.Mvc;

namespace Group1Assignment.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeList : ControllerBase
    {
        //returns a list of employees
        [HttpPost(Name = "GetEmployeeList")]
        public ActionResult<List<Employee>> Post([FromBody]List<Employee>emp)
        {
            return emp;        
        }
    }
}