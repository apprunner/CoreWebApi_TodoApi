﻿// <auto-generated />
using CoreWebApi_TodoApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CoreWebApi_TodoApi.Migrations
{
    [DbContext(typeof(EmployeeContext))]
    [Migration("20200106094845_AddEmployeeData")]
    partial class AddEmployeeData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CoreWebApi_TodoApi.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Department")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Department = "總經理室",
                            Email = "david@gmail.com",
                            Mobile = "0933-152667",
                            Name = "David",
                            Title = "CEO"
                        },
                        new
                        {
                            Id = 2,
                            Department = "人事部",
                            Email = "mary@gmail.com",
                            Mobile = "0938-456889",
                            Name = "Mary",
                            Title = "管理師"
                        },
                        new
                        {
                            Id = 3,
                            Department = "財務部",
                            Email = "joe@gmail.com",
                            Mobile = "0925-331225",
                            Name = "Joe",
                            Title = "經理"
                        },
                        new
                        {
                            Id = 4,
                            Department = "業務部",
                            Email = "mark@gmail.com",
                            Mobile = "0935-863991",
                            Name = "Mark",
                            Title = "業務員"
                        },
                        new
                        {
                            Id = 5,
                            Department = "資訊部",
                            Email = "rose@gmail.com",
                            Mobile = "0987-335668",
                            Name = "Rose",
                            Title = "工程師"
                        },
                        new
                        {
                            Id = 6,
                            Department = "資訊部",
                            Email = "may@gmail.com",
                            Mobile = "0955-259885",
                            Name = "May",
                            Title = "工程師"
                        },
                        new
                        {
                            Id = 7,
                            Department = "業務部",
                            Email = "john@gmail.com",
                            Mobile = "0921-123456",
                            Name = "John",
                            Title = "業務員"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}