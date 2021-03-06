﻿// <auto-generated />
using MegaDeskWebASP.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MegaDeskWebASP.Migrations
{
    [DbContext(typeof(MegaDeskWebASPContext))]
    partial class MegaDeskWebASPContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MegaDeskWebASP.Model.DeskModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Area")
                        .HasColumnType("float");

                    b.Property<string>("Date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Depth")
                        .HasColumnType("float");

                    b.Property<double>("Drawers")
                        .HasColumnType("float");

                    b.Property<string>("Material")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(120)")
                        .HasMaxLength(120);

                    b.Property<double>("Rush")
                        .HasColumnType("float");

                    b.Property<double>("RushCost")
                        .HasColumnType("float");

                    b.Property<double>("TotalCost")
                        .HasColumnType("float");

                    b.Property<double>("Width")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.ToTable("DeskModel");
                });
#pragma warning restore 612, 618
        }
    }
}
