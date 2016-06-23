namespace GitStudy
{
    public interface IRepository
    {
    }

    public interface IRepository<TEntity> : IRepository
        where TEntity : class
    {
        TEntity Add(TEntity entity);
        TEntity Remove(TEntity entity);
    }
}
