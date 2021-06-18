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

        public DbSet<Rephository.Photo> Photo { get; set; }
    }
}
