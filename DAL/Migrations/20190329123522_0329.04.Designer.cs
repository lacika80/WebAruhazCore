﻿// <auto-generated />
using System;
using DAL.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DAL.Migrations
{
    [DbContext(typeof(AruhazContext))]
    [Migration("20190329123522_0329.04")]
    partial class _032904
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DAL.Model.Category", b =>
                {
                    b.Property<int>("CatId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("IsActiveCat")
                        .IsRequired();

                    b.Property<int>("PhotoId");

                    b.Property<int?>("PhotoId1");

                    b.HasKey("CatId");

                    b.HasIndex("PhotoId")
                        .IsUnique();

                    b.HasIndex("PhotoId1");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("DAL.Model.Filler", b =>
                {
                    b.Property<Guid>("ItemId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content");

                    b.Property<int>("No");

                    b.HasKey("ItemId");

                    b.ToTable("Item");
                });

            modelBuilder.Entity("DAL.Model.Filter", b =>
                {
                    b.Property<int>("FId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FName")
                        .IsRequired();

                    b.Property<int>("FsBoss");

                    b.HasKey("FId");

                    b.ToTable("Filter");
                });

            modelBuilder.Entity("DAL.Model.Filter2Product", b =>
                {
                    b.Property<int>("ProdId");

                    b.Property<int>("FId");

                    b.HasKey("ProdId", "FId");

                    b.HasIndex("FId");

                    b.ToTable("Filter2Product");
                });

            modelBuilder.Entity("DAL.Model.Photo", b =>
                {
                    b.Property<int>("PhotoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("Image");

                    b.Property<string>("ImagePath")
                        .IsRequired();

                    b.Property<bool?>("IsActivePhoto")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("1");

                    b.Property<int>("PhotoType");

                    b.HasKey("PhotoId");

                    b.ToTable("Photo");
                });

            modelBuilder.Entity("DAL.Model.Photo2Product", b =>
                {
                    b.Property<int>("ProdId");

                    b.Property<int>("PhotoId");

                    b.HasKey("ProdId", "PhotoId");

                    b.HasIndex("PhotoId");

                    b.ToTable("Product2Photo");
                });

            modelBuilder.Entity("DAL.Model.Product", b =>
                {
                    b.Property<int>("ProdId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("BrutPrice")
                        .HasColumnType("decimal(8, 2)");

                    b.Property<int>("CatId");

                    b.Property<bool?>("IsActiveProd")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("1");

                    b.Property<decimal>("NetPrice")
                        .HasColumnType("decimal(8, 2)");

                    b.Property<int>("PhotoId");

                    b.Property<DateTime>("ProdCreated")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("ProdDescription");

                    b.Property<string>("ProdName")
                        .IsRequired();

                    b.Property<DateTime>("ProdPriceChanged");

                    b.Property<long>("ProdSeen");

                    b.Property<decimal>("VAT")
                        .HasColumnType("decimal(4, 3)");

                    b.HasKey("ProdId");

                    b.HasIndex("CatId");

                    b.HasIndex("PhotoId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("DAL.Model.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<bool>("IsAdmin")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("0");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired();

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired();

                    b.Property<string>("UserName")
                        .IsRequired();

                    b.HasKey("UserId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("DAL.Model.Category", b =>
                {
                    b.HasOne("DAL.Model.Photo", "Photo")
                        .WithOne("Category")
                        .HasForeignKey("DAL.Model.Category", "PhotoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DAL.Model.Photo")
                        .WithMany("Categories")
                        .HasForeignKey("PhotoId1");
                });

            modelBuilder.Entity("DAL.Model.Filter2Product", b =>
                {
                    b.HasOne("DAL.Model.Filter", "Filter")
                        .WithMany("Filter2Product")
                        .HasForeignKey("FId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DAL.Model.Product", "Product")
                        .WithMany("Filter2Product")
                        .HasForeignKey("ProdId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DAL.Model.Photo2Product", b =>
                {
                    b.HasOne("DAL.Model.Photo", "Photo")
                        .WithMany("Photo2Product")
                        .HasForeignKey("PhotoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DAL.Model.Product", "Product")
                        .WithMany("Photo2Product")
                        .HasForeignKey("ProdId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DAL.Model.Product", b =>
                {
                    b.HasOne("DAL.Model.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CatId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DAL.Model.Photo", "Photo")
                        .WithMany("Products")
                        .HasForeignKey("PhotoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
