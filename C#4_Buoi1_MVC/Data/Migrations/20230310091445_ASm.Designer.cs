﻿// <auto-generated />
using System;
using C_4_Buoi1_MVC.Data.CShap4DbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace C_4_Buoi1_MVC.Data.Migrations
{
    [DbContext(typeof(CSharp4DbContext))]
    [Migration("20230310091445_ASm")]
    partial class ASm
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("C_4_Buoi1_MVC.Models.Bill", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Bill", (string)null);
                });

            modelBuilder.Entity("C_4_Buoi1_MVC.Models.BillDetails", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdHD")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdSP")
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdHD");

                    b.HasIndex("IdSP");

                    b.ToTable("BillDetails", (string)null);
                });

            modelBuilder.Entity("C_4_Buoi1_MVC.Models.Cart", b =>
                {
                    b.Property<Guid>("IdUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("IdUser");

                    b.ToTable("Cart", (string)null);
                });

            modelBuilder.Entity("C_4_Buoi1_MVC.Models.CartDetails", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdSP")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdSP");

                    b.HasIndex("IdUser");

                    b.ToTable("CartDetails", (string)null);
                });

            modelBuilder.Entity("C_4_Buoi1_MVC.Models.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AvailbleQuantity")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Supplier")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Product", (string)null);
                });

            modelBuilder.Entity("C_4_Buoi1_MVC.Models.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Role", (string)null);
                });

            modelBuilder.Entity("C_4_Buoi1_MVC.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdRole")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("IdRole");

                    b.ToTable("User", (string)null);
                });

            modelBuilder.Entity("C_4_Buoi1_MVC.Models.Bill", b =>
                {
                    b.HasOne("C_4_Buoi1_MVC.Models.User", "User")
                        .WithMany("Bill")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("C_4_Buoi1_MVC.Models.BillDetails", b =>
                {
                    b.HasOne("C_4_Buoi1_MVC.Models.Bill", "Bill")
                        .WithMany("BillDetails")
                        .HasForeignKey("IdHD")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("C_4_Buoi1_MVC.Models.Product", "Product")
                        .WithMany("BillDetails")
                        .HasForeignKey("IdSP")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bill");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("C_4_Buoi1_MVC.Models.Cart", b =>
                {
                    b.HasOne("C_4_Buoi1_MVC.Models.User", "User")
                        .WithOne("Cart")
                        .HasForeignKey("C_4_Buoi1_MVC.Models.Cart", "IdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("C_4_Buoi1_MVC.Models.CartDetails", b =>
                {
                    b.HasOne("C_4_Buoi1_MVC.Models.Product", "Product")
                        .WithMany("CartDetails")
                        .HasForeignKey("IdSP")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("C_4_Buoi1_MVC.Models.Cart", "Cart")
                        .WithMany("CartDetails")
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cart");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("C_4_Buoi1_MVC.Models.User", b =>
                {
                    b.HasOne("C_4_Buoi1_MVC.Models.Role", "Role")
                        .WithMany("User")
                        .HasForeignKey("IdRole");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("C_4_Buoi1_MVC.Models.Bill", b =>
                {
                    b.Navigation("BillDetails");
                });

            modelBuilder.Entity("C_4_Buoi1_MVC.Models.Cart", b =>
                {
                    b.Navigation("CartDetails");
                });

            modelBuilder.Entity("C_4_Buoi1_MVC.Models.Product", b =>
                {
                    b.Navigation("BillDetails");

                    b.Navigation("CartDetails");
                });

            modelBuilder.Entity("C_4_Buoi1_MVC.Models.Role", b =>
                {
                    b.Navigation("User");
                });

            modelBuilder.Entity("C_4_Buoi1_MVC.Models.User", b =>
                {
                    b.Navigation("Bill");

                    b.Navigation("Cart")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
