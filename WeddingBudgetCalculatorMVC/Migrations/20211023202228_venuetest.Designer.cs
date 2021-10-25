﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WeddingBudgetCalculatorMVC.Data;

namespace WeddingBudgetCalculatorMVC.Migrations
{
    [DbContext(typeof(BudgetDbContext))]
    [Migration("20211023202228_venuetest")]
    partial class venuetest
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WeddingBudgetCalculatorMVC.Models.Budget", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BudgetName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("RemainingBudget")
                        .HasColumnType("float");

                    b.Property<double>("TotalBudget")
                        .HasColumnType("float");

                    b.Property<double>("TotalExpenses")
                        .HasColumnType("float");

                    b.Property<DateTime>("WeddingDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Budgets");
                });

            modelBuilder.Entity("WeddingBudgetCalculatorMVC.Models.ServiceProviders", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("AmountPaid")
                        .HasColumnType("float");

                    b.Property<int?>("BudgetId")
                        .HasColumnType("int");

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PaymentDueDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProviderWebsit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ServiceProviderCost")
                        .HasColumnType("float");

                    b.Property<string>("ServiceProviderName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServiceProviderType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("TaxPercent")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("BudgetId");

                    b.ToTable("ServiceProviders");
                });

            modelBuilder.Entity("WeddingBudgetCalculatorMVC.Models.ServiceProviders", b =>
                {
                    b.HasOne("WeddingBudgetCalculatorMVC.Models.Budget", null)
                        .WithMany("BudgetServiceProviders")
                        .HasForeignKey("BudgetId");
                });

            modelBuilder.Entity("WeddingBudgetCalculatorMVC.Models.Budget", b =>
                {
                    b.Navigation("BudgetServiceProviders");
                });
#pragma warning restore 612, 618
        }
    }
}
