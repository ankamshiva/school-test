using System.Collections.Generic;
using System.Threading.Tasks;
using School.Core;
using School.Core.Models;
using School.Core.Repositories;
using School.Core.Services;
namespace School.Services
{
    public class StudentService : IStudentService
    {
        private readonly IUnitOfWork _unitOfWork;
        public StudentService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public async Task<Student> CreateStudent(Student newStudent)
        {
            await _unitOfWork.Students.AddAsync(newStudent);
            await _unitOfWork.CommitAsync();
            return newStudent;
        }

        public async Task DeleteStudent(Student student)
        {
            _unitOfWork.Students.Remove(student);
            await _unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<Student>> GetAllStudents()
        {
            return await _unitOfWork.Students.GetAllStudentsAsync();
        }

        public async Task<Student> GetStudentById(int id)
        {
            return await _unitOfWork.Students
                .GetWithStudentByIdAsync(id);
        }

        public async Task UpdateStudent(Student studentToBeUpdated, Student student)
        {
            studentToBeUpdated.FirstName = student.FirstName;
            studentToBeUpdated.LastName = student.LastName;
            studentToBeUpdated.Address = student.Address;
            studentToBeUpdated.Email = student.Email;
            studentToBeUpdated.Grade = student.Grade;
            studentToBeUpdated.Class = student.Class;

            await _unitOfWork.CommitAsync();
        }
    }
}