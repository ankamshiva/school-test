using Microsoft.AspNetCore.Mvc;
using School.Core.Models;
using School.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentService _studentService;
        public StudentsController(IStudentService studentService)
        {
            this._studentService = studentService;
        }
        [HttpGet("")]
        public async Task<ActionResult<IEnumerable<Student>>> GetAllStudents()
        {
            var students = await _studentService.GetAllStudents();
            return Ok(students);
        }

        [HttpPost("")]
        public async Task<ActionResult<Student>> SaveStudent(Student student)
        {
            if (student.Id == 0)
            {
                await _studentService.CreateStudent(student);
            }
            else
            {
                var studentToBeUpdated = await _studentService.GetStudentById(student.Id);
                await _studentService.UpdateStudent(studentToBeUpdated, student);
            }
            return Ok(student);
        }
    }
}
