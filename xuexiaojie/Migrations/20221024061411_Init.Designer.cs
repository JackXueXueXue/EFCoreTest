﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using xuexiaojie;

#nullable disable

namespace EFCoreTest.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20221024061411_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EFCoreTest.Models.E_order", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<double>("TotalAmount")
                        .HasColumnType("float(10)");

                    b.Property<int>("TotalQuantity")
                        .HasMaxLength(7)
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("E_order", (string)null);
                });

            modelBuilder.Entity("EFCoreTest.Models.item", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<int>("num")
                        .HasMaxLength(7)
                        .HasColumnType("int");

                    b.Property<double>("price")
                        .HasColumnType("float(10)");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("item", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}