using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Owl.Homie.Domain
{
    public class HomieDbContext : DbContext
    {
        public HomieDbContext(DbContextOptions<HomieDbContext> options) : base(options)
        {

        }

        public DbSet<Bro> Bros { get; set; }
    }
}
