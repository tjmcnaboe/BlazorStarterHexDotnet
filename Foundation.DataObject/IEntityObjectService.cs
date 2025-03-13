namespace Foundation.DataObject
{
    public interface IEntityObjectService<T, TKey> where T : class

    {

        Task<bool> Delete(TKey Id);
        Task<T> Get(TKey id);
        Task<List<T>> GetAll();
        Task<IQueryable<T>> GetAllAsQueryable();
        Task<T> Insert(T entity);
        Task<T> Update(T entityToUpdate);
    }
}
