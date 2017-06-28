using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DOTNETCORE.Models;
using DOTNETCORE.Repositories;

namespace DOTNETCORE.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly IBaseRepo _employeeRepo;

        public ValuesController(IBaseRepo employeeRepo){
            _employeeRepo = employeeRepo;
        }
        // GET api/values
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return _employeeRepo.findAll();
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
