using System;
using System.Threading.Tasks;

namespace School.Core.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IStudentRepository Students { get; }
        ITeacherRepository Teachers { get; }
        Task<int> CommitAsync();
    }
}