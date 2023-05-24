using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMS.eComm.Domain.Core.Interfaces.Services
{
    public interface IBaseService<T>  where T : class
    {
        Task Add(T entity);
         Task<IEnumerable<T>> Getall(T entity);
         Task<T> GetById(Guid id);
         
         void Delete(Guid id);
        void Update(T entity);
    }
}