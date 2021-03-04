﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QTS_SimpleBilling.Model;

namespace QTS_SimpleBilling.Migrations
{
    [DbContext(typeof(BillingContext))]
    [Migration("20210304090636_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("QTS_SimpleBilling.Model.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("QTS_SimpleBilling.Model.Cost", b =>
                {
                    b.Property<int>("CostID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("ItemCode")
                        .HasColumnType("int");

                    b.Property<float>("ItemCost")
                        .HasColumnType("real");

                    b.HasKey("CostID");

                    b.ToTable("Costs");
                });

            modelBuilder.Entity("QTS_SimpleBilling.Model.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasMaxLength(240)
                        .HasColumnType("nvarchar(240)");

                    b.Property<string>("Contact")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("CustomerName")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Email")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("QTS_SimpleBilling.Model.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasMaxLength(240)
                        .HasColumnType("nvarchar(240)");

                    b.Property<string>("Contact")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Email")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("EmployeeCode")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("EmployeeName")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("QTS_SimpleBilling.Model.Item", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Barcode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsService")
                        .HasColumnType("bit");

                    b.Property<int?>("ItemCategoryCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ItemName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ItemUnitUnitId")
                        .HasColumnType("int");

                    b.Property<int?>("ShelfId")
                        .HasColumnType("int");

                    b.HasKey("ItemId");

                    b.HasIndex("ItemCategoryCategoryId");

                    b.HasIndex("ItemUnitUnitId");

                    b.HasIndex("ShelfId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("QTS_SimpleBilling.Model.SellingPrice", b =>
                {
                    b.Property<int>("PriceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("ItemCode")
                        .HasColumnType("int");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.HasKey("PriceId");

                    b.ToTable("SellingPrices");
                });

            modelBuilder.Entity("QTS_SimpleBilling.Model.Shelf", b =>
                {
                    b.Property<int>("ShelfId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ShelfName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShelfId");

                    b.ToTable("Shelves");
                });

            modelBuilder.Entity("QTS_SimpleBilling.Model.Unit", b =>
                {
                    b.Property<int>("UnitId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UnitName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UnitId");

                    b.ToTable("Units");
                });

            modelBuilder.Entity("QTS_SimpleBilling.Model.Item", b =>
                {
                    b.HasOne("QTS_SimpleBilling.Model.Category", "ItemCategory")
                        .WithMany()
                        .HasForeignKey("ItemCategoryCategoryId");

                    b.HasOne("QTS_SimpleBilling.Model.Unit", "ItemUnit")
                        .WithMany()
                        .HasForeignKey("ItemUnitUnitId");

                    b.HasOne("QTS_SimpleBilling.Model.Shelf", "Shelf")
                        .WithMany()
                        .HasForeignKey("ShelfId");

                    b.Navigation("ItemCategory");

                    b.Navigation("ItemUnit");

                    b.Navigation("Shelf");
                });
#pragma warning restore 612, 618
        }
    }
}
