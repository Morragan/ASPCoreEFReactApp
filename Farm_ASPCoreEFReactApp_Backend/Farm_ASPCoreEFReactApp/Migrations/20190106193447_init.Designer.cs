﻿// <auto-generated />
using System;
using Farm_ASPCoreEFReactApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Farm_ASPCoreEFReactApp.Migrations
{
    [DbContext(typeof(FarmDbContext))]
    [Migration("20190106193447_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Farm_ASPCoreEFReactApp.Models.Cultivation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FarmId");

                    b.HasKey("Id");

                    b.HasIndex("FarmId");

                    b.ToTable("Cultivations");
                });

            modelBuilder.Entity("Farm_ASPCoreEFReactApp.Models.Driver", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DaysOfWork");

                    b.Property<DateTime>("EndOfContract");

                    b.Property<int>("FarmId");

                    b.Property<string>("FirstName");

                    b.Property<int>("HoursPerDay");

                    b.Property<string>("LastName");

                    b.Property<DateTime>("StartOfContract");

                    b.Property<float>("UsdPerHour");

                    b.HasKey("Id");

                    b.HasIndex("FarmId");

                    b.ToTable("Drivers");
                });

            modelBuilder.Entity("Farm_ASPCoreEFReactApp.Models.Farm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Farms");
                });

            modelBuilder.Entity("Farm_ASPCoreEFReactApp.Models.Farmer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DaysOfWork");

                    b.Property<DateTime>("EndOfContract");

                    b.Property<int>("FarmId");

                    b.Property<string>("FirstName");

                    b.Property<int>("HoursPerDay");

                    b.Property<string>("LastName");

                    b.Property<DateTime>("StartOfContract");

                    b.Property<float>("UsdPerHour");

                    b.HasKey("Id");

                    b.HasIndex("FarmId");

                    b.ToTable("Farmers");
                });

            modelBuilder.Entity("Farm_ASPCoreEFReactApp.Models.Machine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FarmId");

                    b.HasKey("Id");

                    b.HasIndex("FarmId");

                    b.ToTable("Machines");
                });

            modelBuilder.Entity("Farm_ASPCoreEFReactApp.Models.Stable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FarmId");

                    b.HasKey("Id");

                    b.HasIndex("FarmId");

                    b.ToTable("Stables");
                });

            modelBuilder.Entity("Farm_ASPCoreEFReactApp.Models.Cultivation", b =>
                {
                    b.HasOne("Farm_ASPCoreEFReactApp.Models.Farm", "Farm")
                        .WithMany("Cultivations")
                        .HasForeignKey("FarmId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Farm_ASPCoreEFReactApp.Models.Driver", b =>
                {
                    b.HasOne("Farm_ASPCoreEFReactApp.Models.Farm", "Farm")
                        .WithMany("Drivers")
                        .HasForeignKey("FarmId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Farm_ASPCoreEFReactApp.Models.Farmer", b =>
                {
                    b.HasOne("Farm_ASPCoreEFReactApp.Models.Farm", "Farm")
                        .WithMany("Farmers")
                        .HasForeignKey("FarmId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Farm_ASPCoreEFReactApp.Models.Machine", b =>
                {
                    b.HasOne("Farm_ASPCoreEFReactApp.Models.Farm", "Farm")
                        .WithMany("Machines")
                        .HasForeignKey("FarmId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Farm_ASPCoreEFReactApp.Models.Stable", b =>
                {
                    b.HasOne("Farm_ASPCoreEFReactApp.Models.Farm", "Farm")
                        .WithMany("Stables")
                        .HasForeignKey("FarmId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
