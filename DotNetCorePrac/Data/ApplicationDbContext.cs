using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Threading.Tasks;
using DotNetCorePrac.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNetCorePrac.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) 
        {
                
        }

        public DbSet<Category> Categories { get; set; }

    }
}
