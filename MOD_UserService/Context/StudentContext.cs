using Microsoft.EntityFrameworkCore;
using MOD_UserService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOD_UserService.Context
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) :
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
