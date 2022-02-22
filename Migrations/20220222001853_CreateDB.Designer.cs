﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;
using TravelManagement.Models.Repositories;

namespace TravelManagement.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20220222001853_CreateDB")]
    partial class CreateDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "3.1.17")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            modelBuilder.Entity("TravelManagement.Models.Adress", b =>
                {
                    b.Property<string>("CEP")
                        .HasColumnType("NVARCHAR2(450)");

                    b.Property<string>("City")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Country")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("District")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int>("DriverId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("Number")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Street")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("CEP");

                    b.HasIndex("DriverId")
                        .IsUnique();

                    b.ToTable("Adress");
                });

            modelBuilder.Entity("TravelManagement.Models.Driver", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AdressId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("Name")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int>("TruckId")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("Id");

                    b.ToTable("Driver");
                });

            modelBuilder.Entity("TravelManagement.Models.Travel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DeliveryPlace")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int>("DriverId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("ExitPlace")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<double>("KmBetweenCities")
                        .HasColumnType("BINARY_DOUBLE");

                    b.Property<DateTime>("StartTravel")
                        .HasColumnType("TIMESTAMP(7)");

                    b.HasKey("Id");

                    b.HasIndex("DriverId");

                    b.ToTable("Travel");
                });

            modelBuilder.Entity("TravelManagement.Models.Truck", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Axles")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Brand")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int>("DriverId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("Model")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Plate")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("Id");

                    b.HasIndex("DriverId")
                        .IsUnique();

                    b.ToTable("Truck");
                });

            modelBuilder.Entity("TravelManagement.Models.Adress", b =>
                {
                    b.HasOne("TravelManagement.Models.Driver", "Driver")
                        .WithOne("Adress")
                        .HasForeignKey("TravelManagement.Models.Adress", "DriverId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TravelManagement.Models.Travel", b =>
                {
                    b.HasOne("TravelManagement.Models.Driver", "Driver")
                        .WithMany("Travels")
                        .HasForeignKey("DriverId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TravelManagement.Models.Truck", b =>
                {
                    b.HasOne("TravelManagement.Models.Driver", "Driver")
                        .WithOne("Truck")
                        .HasForeignKey("TravelManagement.Models.Truck", "DriverId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
