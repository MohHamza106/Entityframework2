﻿// <auto-generated />
using System;
using EFCoreAssignment.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFCoreAssignment.Migrations
{
    [DbContext(typeof(DBContext))]
    partial class DBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EFCoreAssignment.Entities.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Topic_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Topic_Id");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("EFCoreAssignment.Entities.Course_Instructor", b =>
                {
                    b.Property<int>("Ins_Id")
                        .HasColumnType("int");

                    b.Property<int>("Crs_Id")
                        .HasColumnType("int");

                    b.Property<string>("Evalute")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Ins_Id", "Crs_Id");

                    b.HasIndex("Crs_Id");

                    b.ToTable("Instructor_Courses");
                });

            modelBuilder.Entity("EFCoreAssignment.Entities.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("HiringDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GetDate()");

                    b.Property<int?>("InstructorId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("InstructorId")
                        .IsUnique()
                        .HasFilter("[InstructorId] IS NOT NULL");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("EFCoreAssignment.Entities.Instructor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double?>("Bouns")
                        .HasColumnType("float");

                    b.Property<int>("DeptId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("HourRate")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar");

                    b.Property<decimal>("Salary")
                        .HasColumnType("Money");

                    b.HasKey("Id");

                    b.HasIndex("DeptId");

                    b.ToTable("Instructors");
                });

            modelBuilder.Entity("EFCoreAssignment.Entities.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 10L, 10);

                    b.Property<string>("Address")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("Cairo");

                    b.Property<decimal>("Age")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar");

                    b.Property<string>("LName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("EFCoreAssignment.Entities.Student_Course", b =>
                {
                    b.Property<int>("Std_Id")
                        .HasColumnType("int");

                    b.Property<int>("Crs_Id")
                        .HasColumnType("int");

                    b.Property<int>("Grade")
                        .HasColumnType("int");

                    b.HasKey("Std_Id", "Crs_Id");

                    b.HasIndex("Crs_Id");

                    b.ToTable("Student_Courses");
                });

            modelBuilder.Entity("EFCoreAssignment.Entities.Topic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Topic");
                });

            modelBuilder.Entity("EFCoreAssignment.Entities.Course", b =>
                {
                    b.HasOne("EFCoreAssignment.Entities.Topic", "Topic")
                        .WithMany("Courses")
                        .HasForeignKey("Topic_Id");

                    b.Navigation("Topic");
                });

            modelBuilder.Entity("EFCoreAssignment.Entities.Course_Instructor", b =>
                {
                    b.HasOne("EFCoreAssignment.Entities.Course", "Course")
                        .WithMany("Course_Instructors")
                        .HasForeignKey("Crs_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFCoreAssignment.Entities.Instructor", "Instructor")
                        .WithMany("Course_Instructors")
                        .HasForeignKey("Ins_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("EFCoreAssignment.Entities.Department", b =>
                {
                    b.HasOne("EFCoreAssignment.Entities.Instructor", "Manager")
                        .WithOne("ManageDepartment")
                        .HasForeignKey("EFCoreAssignment.Entities.Department", "InstructorId");

                    b.Navigation("Manager");
                });

            modelBuilder.Entity("EFCoreAssignment.Entities.Instructor", b =>
                {
                    b.HasOne("EFCoreAssignment.Entities.Department", "ContainDepartment")
                        .WithMany("ContainInstructors")
                        .HasForeignKey("DeptId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ContainDepartment");
                });

            modelBuilder.Entity("EFCoreAssignment.Entities.Student", b =>
                {
                    b.HasOne("EFCoreAssignment.Entities.Department", "Department")
                        .WithMany("Students")
                        .HasForeignKey("DepartmentId");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("EFCoreAssignment.Entities.Student_Course", b =>
                {
                    b.HasOne("EFCoreAssignment.Entities.Course", "Course")
                        .WithMany("Student_Courses")
                        .HasForeignKey("Crs_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFCoreAssignment.Entities.Student", "Student")
                        .WithMany("Student_Courses")
                        .HasForeignKey("Std_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("EFCoreAssignment.Entities.Course", b =>
                {
                    b.Navigation("Course_Instructors");

                    b.Navigation("Student_Courses");
                });

            modelBuilder.Entity("EFCoreAssignment.Entities.Department", b =>
                {
                    b.Navigation("ContainInstructors");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("EFCoreAssignment.Entities.Instructor", b =>
                {
                    b.Navigation("Course_Instructors");

                    b.Navigation("ManageDepartment")
                        .IsRequired();
                });

            modelBuilder.Entity("EFCoreAssignment.Entities.Student", b =>
                {
                    b.Navigation("Student_Courses");
                });

            modelBuilder.Entity("EFCoreAssignment.Entities.Topic", b =>
                {
                    b.Navigation("Courses");
                });
#pragma warning restore 612, 618
        }
    }
}
