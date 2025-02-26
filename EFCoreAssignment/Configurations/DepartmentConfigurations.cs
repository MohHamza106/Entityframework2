using EFCoreAssignment.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAssignment.Configurations
{
    internal class DepartmentConfigurations : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasMany(C => C.Students).WithOne(c => c.Department).HasForeignKey(sc => sc.DepartmentId);
            builder.HasMany(C => C.ContainInstructors).WithOne(c => c.ContainDepartment).HasForeignKey(sc => sc.DeptId);
            builder.HasOne(C => C.Manager).WithOne(c => c.ManageDepartment).HasForeignKey<Department>(sc => sc.InstructorId);
            builder.Property(D => D.HiringDate).HasDefaultValueSql("GetDate()");


        }
    }
}
