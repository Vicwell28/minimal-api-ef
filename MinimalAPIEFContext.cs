using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using minimal_api_ef.Models;
using minimal_api_ef.seeds;

namespace minimal_api_ef
{
    public class MinimalAPIEFContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<TaskApi> Tasks { get; set; }
        public MinimalAPIEFContext(DbContextOptions<MinimalAPIEFContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(C =>
            {
                C.ToTable("Category");
                C.HasKey(p => p.CategoryId);
                C.Property(p => p.Name).IsRequired().HasMaxLength(50);
                C.Property(p => p.Description).IsRequired(false);
                C.Property(p => p.Create_at);
                C.Property(p => p.Peso);

                C.HasData(CategorySeed.GetListCategorySeed());
            });

            modelBuilder.Entity<TaskApi>(T =>
            {
                T.ToTable("Task");
                T.HasKey(p => p.TaskId);
                T.Property(t => t.CategoryId);
                T.Property(p => p.Titulo).IsRequired().HasMaxLength(50);
                T.Property(p => p.Description).IsRequired(false);
                T.Property(p => p.Priority).IsRequired();
                T.Property(p => p.Create_at);
                T.HasOne(p => p.Catrgory).WithMany(p => p.tasks).HasForeignKey(p => p.CategoryId);
                T.Ignore(p => p.Resumen);

                T.HasData(TaskSeed.GetListTaskSeed());
            });
        }

    }
}