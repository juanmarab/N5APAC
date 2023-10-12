using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using PAC.BusinessLogic;
using PAC.Domain;
using PAC.IBusinessLogic;
using PAC.WebAPI.Filters;

namespace PAC.WebAPI
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentLogic _studentLogic;

        public StudentController(IStudentLogic studentLogic)
        {
            this._studentLogic = studentLogic;
        }

        [HttpPost]
        public IActionResult Post([FromBody] Student value)
        {
            _studentLogic.InsertStudents(value);
            return Ok();
        }

        [HttpGet]
        public IActionResult GetById([FromBody] int id)
        {
            var student = _studentLogic.GetStudentById(id);
            return Ok(student);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var students = _studentLogic.GetStudents();
            return Ok(students);
        }

    }
}
