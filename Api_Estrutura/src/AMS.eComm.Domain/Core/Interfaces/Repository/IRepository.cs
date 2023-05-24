namespace AMS.eComm.Domain.Core.Interfaces.Repository
{
    public interface IRepository<T> where T : class
    {
         Task Add(T entity);
         Task<IEnumerable<T>> Getall();
         Task<T> GetById(Guid id);
         
         void Delete(Guid id);
        void Update(T entity);
    }
}