using System;
using System.Data.Entity;
using System.Threading.Tasks;

namespace GitStudy
{
    public interface IDbContextWrapper : IDisposable
    {
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        Action<string> Log { get; set; }
        int? CommandTimeout { get; set; }
        int SaveChanges();
        Task<int> SaveChangesAsync();
        Task<int> SaveChangesAsync(System.Threading.CancellationToken cancellationToken);
    }
}
