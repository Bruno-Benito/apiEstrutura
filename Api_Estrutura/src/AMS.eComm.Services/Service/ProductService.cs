using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AMS.eComm.Domain.Core.Entities;
using AMS.eComm.Domain.Core.Interfaces.Repository;
using AMS.eComm.Domain.Core.Interfaces.Services;

namespace AMS.eComm.Services.Service
{
    public class ProductService : IBaseService<Product>
    {
        private readonly IRepository<Product> _repository;
        public ProductService(IRepository<Product> repository)
        {

        }

        public async Task Add(Product entity)
        {
          await  _repository.Add(entity);
          
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> Getall(Product entity)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}