using Microsoft.EntityFrameworkCore;
using MOD_TechnologyService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOD_TechnologyService.Context
{
    public class TechnologyContext : DbContext
    {
        public TechnologyContext(DbContextOptions<TechnologyContext> options) : base(options)
        {

        }
        public DbSet<Mentor> Mentor { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Training> Training { get; set; }
        public DbSet<Technology> Technology { get; set; }
        public DbSet<Payment> Payment { get; set; }
    }
}
