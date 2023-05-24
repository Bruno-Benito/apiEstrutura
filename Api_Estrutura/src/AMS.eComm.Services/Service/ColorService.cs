using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AMS.eComm.Domain.Core.Entities;
using AMS.eComm.Domain.Core.Interfaces.Repository;
using AMS.eComm.Domain.Core.Interfaces.Services;

namespace AMS.eComm.Services.Service
{
   

    public class ColorService : IBaseService<Color>
    {

         private readonly IRepository<Color> _repository;
        public ColorService(IRepository<Color> repository)
        {

        }


        public Task Add(Color entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Color>> Getall(Color entity)
        {
            throw new NotImplementedException();
        }

        public Task<Color> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Color entity)
        {
            throw new NotImplementedException();
        }
    }
}