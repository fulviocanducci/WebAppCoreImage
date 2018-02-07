using System;
using Microsoft.EntityFrameworkCore;

namespace WebAppCoreImage.Models
{
    public class DataContext: DbContext
    {
        public DbSet<Image> Image { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=DbImg;User Id=sa;Password=senha;MultipleActiveResultSets=true;", c =>
            {
            });
        }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(ImageMap.Create());
        }
    }
}
