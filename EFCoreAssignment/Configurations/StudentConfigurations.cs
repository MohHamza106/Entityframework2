using EFCoreAssignment.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAssignment.Configurations
{
    internal class StudentConfigurations : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(S => S.Id);
            builder.Property(S => S.Id).UseIdentityColumn(10, 10).ValueGeneratedOnAdd();
            builder.Property(S => S.FName).IsRequired().HasColumnType("varchar").HasMaxLength(20);
            builder.Property(S => S.Address).HasDefaultValue("Cairo");
            builder.Property(S => S.Age).HasColumnType("decimal(18,2)");
            builder.Property(S => S.LName).IsRequired(false);
            builder.HasMany(C => C.Student_Courses).WithOne(c => c.Student).HasForeignKey(sc => sc.Std_Id);

        }
    }
}
