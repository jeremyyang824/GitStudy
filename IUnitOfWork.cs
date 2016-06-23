using System;

namespace GitStudy
{
    public interface IUnitOfWork : IDisposable
    {
        int Commit();
        T GetRepository<T>() where T : IRepository;
    }
}
