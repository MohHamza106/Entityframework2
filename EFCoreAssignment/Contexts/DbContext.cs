using EFCoreAssignment.Configurations;
using EFCoreAssignment.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAssignment.Contexts
{
    internal class DBContext : DbContext 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = DevTest ; Trusted_Connection = true ; Encrypt = false ");
            
        }

        #region Dbsets
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }

        public DbSet<Instructor> Instructors { get; set; }

        public DbSet<Topic> Topic { get; set; }
        public DbSet<Student_Course> Student_Courses { get; set; }

        public DbSet<Course_Instructor> Instructor_Courses { get; set; }

        #endregion
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Student>().HasKey(S => S.Id);
            // modelBuilder.Entity<Student>().Property(S => S.Id).UseIdentityColumn(10, 10).ValueGeneratedOnAdd();
            // modelBuilder.Entity<Student>().Property(S => S.FName).IsRequired().HasColumnType("varchar").HasMaxLength(20);
            // modelBuilder.Entity<Student>().Property(S => S.Address).HasDefaultValue("Cairo");
            // modelBuilder.Entity<Student>().Property(S => S.Age).HasColumnType("decimal(18,2)");
            // modelBuilder.Entity<Student>().Property(S => S.LName).IsRequired(false);

          
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());


        }


    }
}
