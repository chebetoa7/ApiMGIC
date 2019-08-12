using ApiMGIC.Model.Store;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiMGIC.Model.Assigne;

namespace ApiMGIC.Data.Entities
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<store> stores { get; set; }

        public DbSet<ApiMGIC.Model.Assigne.assigne> assigne { get; set; }

    }
}
