using School.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Core.Services
{
    public interface IStudentService
    {
        Task<IEnumerable<Student>> GetAllStudents();
        Task<Student> GetStudentById(int id);
        Task<Student> CreateStudent(Student newStudent);
        Task UpdateStudent(Student studentToBeUpdated, Student student);
        Task DeleteStudent(Student student);
    }
}