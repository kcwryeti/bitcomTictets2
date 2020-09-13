using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace bitcomTictets.DataModels
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public DbSet<Ticket> tickets {get; set;}

        public ApplicationDbContext(DbContextOptions options) : base(options)
        { 
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

    }
}
