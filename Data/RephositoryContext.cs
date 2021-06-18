using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Rephository;
using Rephository.Models;
using Microsoft.Extensions.Configuration;

namespace Rephository.Data
{
    public class RephositoryContext : DbContext
    {
        public RephositoryContext (DbContextOptions<RephositoryContext> options)
            : base(options)
        {
        }
        public DbSet<Rephository.Models.Photo> Photos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Photo>().ToTable("Photo");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                .AddUserSecrets<Program>()
                .Build();

            if (!optionsBuilder.IsConfigured)
            {
                var connectionString = configuration["ConnectionStrings:RephositoryContext"];
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
    }
}
