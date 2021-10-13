using School.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Core.Services
{
    public interface ITeacherService
    {
        Task<IEnumerable<Teacher>> GetAllTeachers();
        Task<Teacher> GetTeacherById(int id);
        Task<Teacher> CreateTeacher(Teacher newMusic);
        Task UpdateTeacher(Teacher seacherToBeUpdated, Teacher seacher);
        Task DeleteTeacher(Teacher seacher);
    }
}
