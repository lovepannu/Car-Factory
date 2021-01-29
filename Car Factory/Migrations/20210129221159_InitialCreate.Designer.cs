﻿// <auto-generated />
using Car_Factory.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Car_Factory.Migrations
{
    [DbContext(typeof(Car_FactoryContext))]
    [Migration("20210129221159_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Car_Factory.Models.Buyer", b =>
                {
                    b.Property<int>("BuyerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BuyerAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BuyerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ContactNumber")
                        .HasColumnType("int");

                    b.Property<int>("SellerID")
                        .HasColumnType("int");

                    b.HasKey("BuyerID");

                    b.HasIndex("SellerID");

                    b.ToTable("Buyer");
                });

            modelBuilder.Entity("Car_Factory.Models.Car", b =>
                {
                    b.Property<int>("CarID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CarModel")
                        .HasColumnType("int");

                    b.Property<string>("CarName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FuelType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CarID");

                    b.ToTable("Car");
                });

            modelBuilder.Entity("Car_Factory.Models.Price", b =>
                {
                    b.Property<int>("PriceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CarID")
                        .HasColumnType("int");

                    b.Property<string>("CarName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CarPrice")
                        .HasColumnType("int");

                    b.HasKey("PriceID");

                    b.HasIndex("CarID");

                    b.ToTable("Price");
                });

            modelBuilder.Entity("Car_Factory.Models.Seller", b =>
                {
                    b.Property<int>("SellerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CarID")
                        .HasColumnType("int");

                    b.Property<int>("ContactNumber")
                        .HasColumnType("int");

                    b.Property<string>("EmailId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SellerName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SellerID");

                    b.HasIndex("CarID");

                    b.ToTable("Seller");
                });

            modelBuilder.Entity("Car_Factory.Models.Buyer", b =>
                {
                    b.HasOne("Car_Factory.Models.Seller", "Seller_ID")
                        .WithMany()
                        .HasForeignKey("SellerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Car_Factory.Models.Price", b =>
                {
                    b.HasOne("Car_Factory.Models.Car", "Car_ID")
                        .WithMany()
                        .HasForeignKey("CarID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Car_Factory.Models.Seller", b =>
                {
                    b.HasOne("Car_Factory.Models.Car", "Car_ID")
                        .WithMany()
                        .HasForeignKey("CarID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
