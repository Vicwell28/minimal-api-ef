using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using minimal_api_ef.Models;

namespace minimal_api_ef
{
    public class MinimalAPIEFContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<TaskApi> Tasks { get; set; }

        public MinimalAPIEFContext(DbContextOptions<MinimalAPIEFContext> options) : base(options)
        {

        }
    }
}