using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc2019.Models;

namespace SalesWebMvc2019.Models.SalesWebMvc
{
    public class Context : DbContext
    {
        public Context (DbContextOptions<Context> options)
            : base(options)
        {
        }

        public DbSet<SalesWebMvc2019.Models.Department> Department { get; set; }
    }
}
