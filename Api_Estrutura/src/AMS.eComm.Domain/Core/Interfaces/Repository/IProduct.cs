using AMS.eComm.Domain.Core.Entities;

namespace AMS.eComm.Domain.Core.Interfaces.Repository
{
    public interface IProduct : IRepository<Product>
    {
         void Delete(Guid id);
    }
}