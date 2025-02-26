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
    internal class Crs_InsConfigurations : IEntityTypeConfiguration<Course_Instructor>
    {
        public void Configure(EntityTypeBuilder<Course_Instructor> builder)
        {
            builder.HasKey(ci => new {ci.Ins_Id,ci.Crs_Id});
            builder.HasOne(C => C.Instructor).WithMany(c => c.Course_Instructors).HasForeignKey(sc => sc.Ins_Id);

        }
    }
}
