﻿// <auto-generated />
using System;
using CodeSecond.DataConnect;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CodeSecond.Migrations
{
    [DbContext(typeof(FirstTimeContext))]
    [Migration("20220304081956_die")]
    partial class die
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CodeSecond.DTOs.GradeDTO", b =>
                {
                    b.Property<int>("StudentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentID"), 1L, 1);

                    b.Property<DateTime?>("DateOfBirth")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Height")
                        .HasColumnType("decimal(18,2)");

                    b.Property<byte[]>("Photo")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("StudentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Weight")
                        .HasColumnType("real");

                    b.Property<string>("diemotherfuck")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("xamlz")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("xoamedi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentID");

                    b.ToTable("Grades");
                });

            modelBuilder.Entity("CodeSecond.DTOs.StudentDTO", b =>
                {
                    b.Property<int>("GradeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GradeId"), 1L, 1);

                    b.Property<string>("GradeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Section")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StudentDTOGradeId")
                        .HasColumnType("int");

                    b.HasKey("GradeId");

                    b.HasIndex("StudentDTOGradeId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("CodeSecond.DTOs.StudentDTO", b =>
                {
                    b.HasOne("CodeSecond.DTOs.StudentDTO", null)
                        .WithMany("Students")
                        .HasForeignKey("StudentDTOGradeId");
                });

            modelBuilder.Entity("CodeSecond.DTOs.StudentDTO", b =>
                {
                    b.Navigation("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
