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
    internal class CourseConfigurations : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasMany(C=>C.Student_Courses).WithOne(c => c.Course).HasForeignKey(sc=>sc.Crs_Id);
            builder.HasMany(C => C.Course_Instructors).WithOne(c => c.Course).HasForeignKey(sc => sc.Crs_Id);
            builder.HasOne(C => C.Topic).WithMany(c => c.Courses).HasForeignKey(sc => sc.Topic_Id);


        }
    }
}
