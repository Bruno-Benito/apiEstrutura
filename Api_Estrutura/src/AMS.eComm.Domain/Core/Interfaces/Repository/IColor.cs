using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AMS.eComm.Domain.Core.Entities;

namespace AMS.eComm.Domain.Core.Interfaces.Repository
{
    public interface IColor: IRepository<Color>
    {
        void Delete(Guid id);
    }
}