﻿// <auto-generated />
using Assignment_5.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Assignment_5.Migrations
{
    [DbContext(typeof(BookstoreDBcontext))]
    partial class BookstoreDBcontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.3");

            modelBuilder.Entity("Assignment_5.Models.Project", b =>
                {
                    b.Property<int>("Bookid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Author_FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Author_LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Author_MiddleName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Classification")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Pages")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<string>("Publisher")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Bookid");

                    b.ToTable("Projects");
                });
#pragma warning restore 612, 618
        }
    }
}
