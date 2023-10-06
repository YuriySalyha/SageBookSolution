namespace Repository
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        void Add(TEntity item);
        TEntity FindById(object id);
        IEnumerable<TEntity> GetAll();

        IEnumerable<TEntity> FindAll(Func<TEntity, bool> predicate);
        void Update(TEntity entity);
        void Remove(TEntity entity);
    }
}