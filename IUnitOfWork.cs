using System;

namespace Emico.Data.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        int Commit();
        T GetRepository<T>() where T : IRepository;
    }
}
