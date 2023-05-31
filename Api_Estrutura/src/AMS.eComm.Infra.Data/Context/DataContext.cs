using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AMS.eComm.Domain.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace AMS.eComm.Infra.Data.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext>options)
        :base(options){}

        DbSet<Product> Product {get ; set;}
        DbSet<Color> Color {get;set;}

    }
}