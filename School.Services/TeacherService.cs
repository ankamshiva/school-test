using System.Collections.Generic;
using System.Threading.Tasks;
using School.Core;
using School.Core.Models;
using School.Core.Repositories;
using School.Core.Services;
namespace School.Services
{
    public class TeacherService : ITeacherService
    {
        private readonly IUnitOfWork _unitOfWork;
        public TeacherService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public async Task<Teacher> CreateTeacher(Teacher newTeacher)
        {
            await _unitOfWork.Teachers.AddAsync(newTeacher);
            await _unitOfWork.CommitAsync();
            return newTeacher;
        }

        public async Task DeleteTeacher(Teacher teacher)
        {
            _unitOfWork.Teachers.Remove(teacher);
            await _unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<Teacher>> GetAllTeachers()
        {
            return await _unitOfWork.Teachers.GetAllTeachersAsync();
        }

        public async Task<Teacher> GetTeacherById(int id)
        {
            return await _unitOfWork.Teachers
                .GetWithTeacherByIdAsync(id);
        }

        public async Task UpdateTeacher(Teacher teacherToBeUpdated, Teacher teacher)
        {
            teacherToBeUpdated.FirstName = teacher.FirstName;
            teacherToBeUpdated.LastName = teacher.LastName;
            teacherToBeUpdated.Address = teacher.Address;
            teacherToBeUpdated.Email = teacher.Email;
            teacherToBeUpdated.Grade = teacher.Grade;
            teacherToBeUpdated.Class = teacher.Class;
            teacherToBeUpdated.TeachingFrom = teacher.TeachingFrom;

            await _unitOfWork.CommitAsync();
        }
    }
}