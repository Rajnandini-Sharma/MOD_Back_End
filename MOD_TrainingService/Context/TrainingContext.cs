using Microsoft.EntityFrameworkCore;
using MOD_TrainingService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOD_TrainingService.Context
{
    public class TrainingContext : DbContext
    {
        public TrainingContext(DbContextOptions<TrainingContext> options) :
            base(options)
        {

        }
        public DbSet<Mentor> Mentor { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Training> Training { get; set; }
        public DbSet<Technology> Technology { get; set; }
        public DbSet<Payment> Payment { get; set; }
    }
}
