using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using pnphuc2050531200254.Models;

namespace pnphuc2050531200254.Data
{
    public class CNContext : DbContext
    {
        public CNContext (DbContextOptions<CNContext> options)
            : base(options)
        {
        }
        public DbSet<congNhan> Students { get; set; }
        public DbSet<caLamViec> Enrollments { get; set; }
        public DbSet<bangDangKi> Courses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<bangDangKi>().ToTable("Course");
            modelBuilder.Entity<caLamViec>().ToTable("Enrollment");
            modelBuilder.Entity<congNhan>().ToTable("Student");
        }
        
    }
}
