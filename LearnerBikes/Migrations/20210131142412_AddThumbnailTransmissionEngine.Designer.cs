﻿// <auto-generated />
using LearnerBikes.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LearnerBikes.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210131142412_AddThumbnailTransmissionEngine")]
    partial class AddThumbnailTransmissionEngine
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("LearnerBikes.Models.Bike", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("BikeType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DryWeight")
                        .HasColumnType("int");

                    b.Property<string>("Engine")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Make")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaxYear")
                        .HasColumnType("int");

                    b.Property<int>("MinYear")
                        .HasColumnType("int");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Power")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeatHeight")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("TankCapacity")
                        .HasColumnType("float");

                    b.Property<string>("ThumbnailUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Transmission")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WetWeight")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Bikes");
                });
#pragma warning restore 612, 618
        }
    }
}
