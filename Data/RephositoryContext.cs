using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Rephository;

namespace Rephository.Data
{
    public class RephositoryContext : DbContext
    {
        public RephositoryContext (DbContextOptions<RephositoryContext> options)
            : base(options)
        {
        }

        public DbSet<Rephository.Photo> Photos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Photo>().ToTable("Photo");
        }
    }
}
