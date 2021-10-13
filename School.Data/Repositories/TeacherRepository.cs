using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using School.Core.Models;
using School.Core.Repositories;

namespace School.Data.Repositories
{
    public class TeacherRepository : Repository<Teacher>, ITeacherRepository
    {
        public TeacherRepository(SchoolDbContext context)
            : base(context)
        { }

        private SchoolDbContext SchoolDbContext
        {
            get { return Context as SchoolDbContext; }
        }

        public async Task<IEnumerable<Teacher>> GetAllTeachersAsync()
        {
            return await SchoolDbContext.Teachers
                    .ToListAsync();
        }


        public async Task<Teacher> GetWithTeacherByIdAsync(int id)
        {
            return await SchoolDbContext.Teachers
                                .SingleOrDefaultAsync(m => m.Id == id);
        }
    }
}