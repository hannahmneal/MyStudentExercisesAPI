using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyStudentExercisesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        // GET api/Students
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/Students/5
        [HttpGet("{id}", Name = "GetStudent")]
        public string Get(int id)
        {
            return "value";
        }

        //NOTE: no change to POST
        // POST api/Students        
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        //NOTE: no change to PUT
        // PUT api/Students/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/ApiWithActions/5      //This doesn't say "Student" like the others
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
