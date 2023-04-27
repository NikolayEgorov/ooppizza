﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using pizza;

#nullable disable

namespace collections.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20230427150524_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("ItemProduct", b =>
                {
                    b.Property<int>("itemsid")
                        .HasColumnType("INTEGER");

                    b.Property<int>("productsid")
                        .HasColumnType("INTEGER");

                    b.HasKey("itemsid", "productsid");

                    b.HasIndex("productsid");

                    b.ToTable("ItemProduct");
                });

            modelBuilder.Entity("pizza.Models.Item", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Orderid")
                        .HasColumnType("INTEGER");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.HasIndex("Orderid");

                    b.ToTable("Item");
                });

            modelBuilder.Entity("pizza.Models.Order", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("userid")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.HasIndex("userid");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("pizza.Models.Product", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("pizza.Models.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("surname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("ItemProduct", b =>
                {
                    b.HasOne("pizza.Models.Item", null)
                        .WithMany()
                        .HasForeignKey("itemsid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("pizza.Models.Product", null)
                        .WithMany()
                        .HasForeignKey("productsid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("pizza.Models.Item", b =>
                {
                    b.HasOne("pizza.Models.Order", null)
                        .WithMany("items")
                        .HasForeignKey("Orderid");
                });

            modelBuilder.Entity("pizza.Models.Order", b =>
                {
                    b.HasOne("pizza.Models.User", "user")
                        .WithMany("orders")
                        .HasForeignKey("userid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("user");
                });

            modelBuilder.Entity("pizza.Models.Order", b =>
                {
                    b.Navigation("items");
                });

            modelBuilder.Entity("pizza.Models.User", b =>
                {
                    b.Navigation("orders");
                });
#pragma warning restore 612, 618
        }
    }
}