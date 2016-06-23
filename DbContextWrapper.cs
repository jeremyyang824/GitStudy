using System;
using System.Data.Entity;
using System.Threading.Tasks;

namespace GitStudy
{
    public class DbContextWrapper : IDbContextWrapper
    {
        public DbContextWrapper(DbContext context)
        {
            if (context == null)
                throw new ArgumentNullException("context");

            this.DbContext = context;
        }

        #region IDbContextAdapter
        protected DbContext DbContext
        {
            get;
            private set;
        }
        public DbSet<TEntity> Set<TEntity>() 
            where TEntity : class
        {
            return this.DbContext.Set<TEntity>();
        }

        public Action<string> Log 
        {
            get
            {
                return this.DbContext.Database.Log;
            }
            set
            {
                this.DbContext.Database.Log = value;
            } 
        }

        public int? CommandTimeout
        {
            get
            {
                return this.DbContext.Database.CommandTimeout;
            }
            set
            {
                this.DbContext.Database.CommandTimeout = value;
            }
        }

        public int SaveChanges()
        {
            return this.DbContext.SaveChanges();
        }

        public Task<int> SaveChangesAsync()
        {
            return this.DbContext.SaveChangesAsync();
        }

        public Task<int> SaveChangesAsync(System.Threading.CancellationToken cancellationToken)
        {
            return this.DbContext.SaveChangesAsync(cancellationToken);
        }

        public void Dispose()
        {
            this.DbContext.Dispose();
        }

        #endregion
    }
}
