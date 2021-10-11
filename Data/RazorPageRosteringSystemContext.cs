using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPageRosteringSystem.Models;

namespace RazorPageRosteringSystem.Data
{
    public class RazorPageRosteringSystemContext : DbContext
    {
        public RazorPageRosteringSystemContext (DbContextOptions<RazorPageRosteringSystemContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPageRosteringSystem.Models.Staff> Staff { get; set; }

        public DbSet<RazorPageRosteringSystem.Models.Role> Role { get; set; }
    }
}
