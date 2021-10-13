using School.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace School.Core.Repositories
{
    public interface IStudentRepository: IRepository<Student>
    {
        Task<IEnumerable<Student>> GetAllStudentsAsync();
        Task<Student> GetWithStudentByIdAsync(int id);
    }
}
