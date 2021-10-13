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
    public class TeachersController: ControllerBase
    {
        private readonly ITeacherService _teacherService;
        public TeachersController(ITeacherService teacherService)
        {
            this._teacherService = teacherService;
        }
        [HttpGet("")]
        public async Task<ActionResult<IEnumerable<Teacher>>> GetAllTeachers()
        {
            var Teachers = await _teacherService.GetAllTeachers();
            return Ok(Teachers);
        }

        [HttpPost("")]
        public async Task<ActionResult<Teacher>> SaveTeacher(Teacher teacher)
        {
            if (teacher.Id == 0)
            {
                await _teacherService.CreateTeacher(teacher);
            }
            else
            {
                var teacherToBeUpdated = await _teacherService.GetTeacherById(teacher.Id);
                await _teacherService.UpdateTeacher(teacherToBeUpdated, teacher);
            }
            return Ok(teacher);
        }
    }
}
