using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AMS.eComm.Domain.Core.Entities;
using AMS.eComm.Domain.Core.Interfaces.Repository;
using AMS.eComm.Domain.Core.Interfaces.Services;

namespace AMS.eComm.Services.Service
{
    public class CategoryService : IBaseService<Category>
    {
         private readonly IRepository<Category> _repository;
        public CategoryService(IRepository<Category> repository)
        {

        }

        public Task Add(Category entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Category>> Getall(Category entity)
        {
            throw new NotImplementedException();
        }

        public Task<Category> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}