using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SchoolApi.Data.Entities;
using SchoolApi.Services;

namespace SchoolApi.Controllers
{
    [Route("api/student/")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        
        // GET api/values
        [HttpGet]
        [ProducesResponseType(404)]
        public async Task<IActionResult> Get()
        {
            var resultList = await _studentService.GetAll();
            if (!resultList.Any())
            {
                return NotFound();
            }
            
            return Ok(resultList);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var student = await _studentService.GetById(id);
            if (student == null) {
                return NotFound();
            }
            
            return Ok(student);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}