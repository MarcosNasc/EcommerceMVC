﻿// <auto-generated />
using System;
using Ecommerce.DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Ecommerce.DAL.Migrations
{
    [DbContext(typeof(EcommerceDBContext))]
    partial class EcommerceDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Ecommerce.BLL.Entities.Address", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("Complement")
                        .IsRequired()
                        .HasColumnType("VARCHAR(250)");

                    b.Property<string>("Neighborhood")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("StreetName")
                        .IsRequired()
                        .HasColumnType("VARCHAR(200)");

                    b.Property<Guid>("SupplierId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("VARCHAR(8)");

                    b.HasKey("Id");

                    b.HasIndex("SupplierId")
                        .IsUnique();

                    b.ToTable("Addresses", (string)null);
                });

            modelBuilder.Entity("Ecommerce.BLL.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("VARCHAR(1000)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("VARCHAR(200)");

                    b.Property<Guid>("SupplierId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Value")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("SupplierId");

                    b.ToTable("Products", (string)null);
                });

            modelBuilder.Entity("Ecommerce.BLL.Entities.Supplier", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Document")
                        .IsRequired()
                        .HasColumnType("VARCHAR(14)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("VARCHAR(200)");

                    b.Property<int>("SupplierType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Suppliers", (string)null);
                });

            modelBuilder.Entity("Ecommerce.BLL.Entities.Address", b =>
                {
                    b.HasOne("Ecommerce.BLL.Entities.Supplier", "Supplier")
                        .WithOne("Address")
                        .HasForeignKey("Ecommerce.BLL.Entities.Address", "SupplierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("Ecommerce.BLL.Entities.Product", b =>
                {
                    b.HasOne("Ecommerce.BLL.Entities.Supplier", "Supplier")
                        .WithMany("Products")
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("Ecommerce.BLL.Entities.Supplier", b =>
                {
                    b.Navigation("Address");

                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
