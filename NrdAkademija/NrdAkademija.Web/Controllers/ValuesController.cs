using Microsoft.AspNetCore.Mvc;
using NrdAkademija.Ef.repositories;

namespace NrdAkademija.Web.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        IEmployeeRepository _employee;
        public ValuesController(IEmployeeRepository employee)
        {
            _employee = employee;
        }
        // GET api/values
        [HttpGet]
        public void Get()
        {
            var employeeList = _employee.GetEmployees();
            //employee.FirstName = "Linas";
            //_ctx.SaveChanges();


            //return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
