using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace todolistapp.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Users> users { get; set; }
        public DbSet<Tasks> tasks { get; set; }


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
    }
}
