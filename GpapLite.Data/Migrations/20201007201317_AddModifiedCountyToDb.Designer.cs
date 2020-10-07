﻿// <auto-generated />
using System;
using GpapLite.Data.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GpapLite.Data.Migrations
{
    [DbContext(typeof(GpapDbContext))]
    [Migration("20201007201317_AddModifiedCountyToDb")]
    partial class AddModifiedCountyToDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GpapLite.Data.Models.County", b =>
                {
                    b.Property<string>("CountryId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("CountryId");

                    b.ToTable("Counties");
                });

            modelBuilder.Entity("GpapLite.Data.Models.Location", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int?>("SubCountyId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SubCountyId");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("GpapLite.Data.Models.SubCounty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CountyCountryId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("CountyId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CountyCountryId");

                    b.ToTable("SubCounties");
                });

            modelBuilder.Entity("GpapLite.Data.Models.Location", b =>
                {
                    b.HasOne("GpapLite.Data.Models.SubCounty", null)
                        .WithMany("Locations")
                        .HasForeignKey("SubCountyId");
                });

            modelBuilder.Entity("GpapLite.Data.Models.SubCounty", b =>
                {
                    b.HasOne("GpapLite.Data.Models.County", "County")
                        .WithMany("SubCounties")
                        .HasForeignKey("CountyCountryId");
                });
#pragma warning restore 612, 618
        }
    }
}
