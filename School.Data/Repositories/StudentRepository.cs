using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using School.Core.Models;
using School.Core.Repositories;

namespace School.Data.Repositories
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public StudentRepository(SchoolDbContext context)
            : base(context)
        { }

        private SchoolDbContext SchoolDbContext
        {
            get { return Context as SchoolDbContext; }
        }

        public async Task<IEnumerable<Student>> GetAllStudentsAsync()
        {
            return await SchoolDbContext.Students
                    .ToListAsync();
        }


        public async Task<Student> GetWithStudentByIdAsync(int id)
        {
            return await SchoolDbContext.Students
                                .SingleOrDefaultAsync(m => m.Id == id);
        }
    }
}