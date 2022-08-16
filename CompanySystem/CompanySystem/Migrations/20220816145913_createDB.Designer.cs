﻿// <auto-generated />
using System;
using CompanySystem.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CompanySystem.Migrations
{
    [DbContext(typeof(WorkingDB))]
    [Migration("20220816145913_createDB")]
    partial class createDB
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-preview.7.22376.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CompanySystem.Model.Company", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("CompanySystem.Model.Department", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("CompanySystem.Model.DepartmentOfCompany", b =>
                {
                    b.Property<int>("CompanyID")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.Property<int>("DepartmentID")
                        .HasColumnType("int")
                        .HasColumnOrder(2);

                    b.HasKey("CompanyID", "DepartmentID")
                        .HasName("PK_CompanyDepartment");

                    b.HasIndex("DepartmentID");

                    b.ToTable("DepartmentOfCompany", (string)null);
                });

            modelBuilder.Entity("CompanySystem.Model.Employee", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CompanyID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("DepartmentID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("CompanyID");

                    b.HasIndex("DepartmentID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("CompanySystem.Model.DepartmentOfCompany", b =>
                {
                    b.HasOne("CompanySystem.Model.Company", "Company")
                        .WithMany("Departments")
                        .HasForeignKey("CompanyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CompanySystem.Model.Department", "Department")
                        .WithMany("Companies")
                        .HasForeignKey("DepartmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("CompanySystem.Model.Employee", b =>
                {
                    b.HasOne("CompanySystem.Model.Company", "Company")
                        .WithMany("Employees")
                        .HasForeignKey("CompanyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CompanySystem.Model.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("CompanySystem.Model.Company", b =>
                {
                    b.Navigation("Departments");

                    b.Navigation("Employees");
                });

            modelBuilder.Entity("CompanySystem.Model.Department", b =>
                {
                    b.Navigation("Companies");

                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
