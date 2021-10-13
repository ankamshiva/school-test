
using System.Threading.Tasks;
using School.Core;
using School.Core.Repositories;
using School.Data.Repositories;

namespace School.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SchoolDbContext _context;
        private StudentRepository _studentRepository;
        private TeacherRepository _teacherRepository;

        public UnitOfWork(SchoolDbContext context)
        {
            this._context = context;
        }

        public IStudentRepository Students => _studentRepository = _studentRepository ?? new StudentRepository(_context);

        public ITeacherRepository Teachers => _teacherRepository = _teacherRepository ?? new TeacherRepository(_context);

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}