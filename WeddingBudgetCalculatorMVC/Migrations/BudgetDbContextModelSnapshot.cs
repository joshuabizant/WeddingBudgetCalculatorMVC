// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WeddingBudgetCalculatorMVC.Data;

namespace WeddingBudgetCalculatorMVC.Migrations
{
    [DbContext(typeof(BudgetDbContext))]
    partial class BudgetDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("ProviderWebsite")
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

            modelBuilder.Entity("WeddingBudgetCalculatorMVC.Models.BeverageProvider", b =>
                {
                    b.HasBaseType("WeddingBudgetCalculatorMVC.Models.ServiceProviders");

                    b.Property<double>("BartenderCost")
                        .HasColumnType("float");

                    b.Property<double>("BeveragePackageCost")
                        .HasColumnType("float");

                    b.Property<double>("BeverageServicePercent")
                        .HasColumnType("float");

                    b.Property<string>("BeverageType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("RestaurantTaxPercent")
                        .HasColumnType("float");

                    b.ToTable("BeverageProviders");
                });

            modelBuilder.Entity("WeddingBudgetCalculatorMVC.Models.Caterer", b =>
                {
                    b.HasBaseType("WeddingBudgetCalculatorMVC.Models.ServiceProviders");

                    b.Property<double>("CatererCost")
                        .HasColumnType("float");

                    b.Property<string>("CatererStyle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("RestaurantTaxPercent")
                        .HasColumnType("float");

                    b.Property<double>("ServiceChargePercent")
                        .HasColumnType("float");

                    b.ToTable("Caterers");
                });

            modelBuilder.Entity("WeddingBudgetCalculatorMVC.Models.DJ", b =>
                {
                    b.HasBaseType("WeddingBudgetCalculatorMVC.Models.ServiceProviders");

                    b.Property<double>("DJCost")
                        .HasColumnType("float");

                    b.Property<int>("HoursOnsite")
                        .HasColumnType("int");

                    b.ToTable("DJs");
                });

            modelBuilder.Entity("WeddingBudgetCalculatorMVC.Models.Florist", b =>
                {
                    b.HasBaseType("WeddingBudgetCalculatorMVC.Models.ServiceProviders");

                    b.Property<double>("CostOfBoquets")
                        .HasColumnType("float");

                    b.Property<double>("CostOfCorsages")
                        .HasColumnType("float");

                    b.Property<double>("DecorativeFlowerCost")
                        .HasColumnType("float");

                    b.Property<double>("FlowerAdditionalCost")
                        .HasColumnType("float");

                    b.Property<int>("NumberOfBoquets")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfCorsages")
                        .HasColumnType("int");

                    b.ToTable("Florists");
                });

            modelBuilder.Entity("WeddingBudgetCalculatorMVC.Models.FoodProvider", b =>
                {
                    b.HasBaseType("WeddingBudgetCalculatorMVC.Models.ServiceProviders");

                    b.Property<double>("FoodCost")
                        .HasColumnType("float");

                    b.Property<string>("FoodItem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("RestaurantTaxPercent")
                        .HasColumnType("float");

                    b.Property<double>("ServiceChargePercent")
                        .HasColumnType("float");

                    b.ToTable("FoodProviders");
                });

            modelBuilder.Entity("WeddingBudgetCalculatorMVC.Models.Photographer", b =>
                {
                    b.HasBaseType("WeddingBudgetCalculatorMVC.Models.ServiceProviders");

                    b.Property<int>("HoursOfPhotos")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfPhotographers")
                        .HasColumnType("int");

                    b.Property<double>("PhotographerCost")
                        .HasColumnType("float");

                    b.ToTable("Photographers");
                });

            modelBuilder.Entity("WeddingBudgetCalculatorMVC.Models.Venue", b =>
                {
                    b.HasBaseType("WeddingBudgetCalculatorMVC.Models.ServiceProviders");

                    b.Property<double>("CeremonyCost")
                        .HasColumnType("float");

                    b.Property<double>("CleaningCost")
                        .HasColumnType("float");

                    b.Property<double>("DecorationCost")
                        .HasColumnType("float");

                    b.Property<double>("SecurityCost")
                        .HasColumnType("float");

                    b.Property<double>("VenueAdditionalCost")
                        .HasColumnType("float");

                    b.Property<double>("VenueRentalCost")
                        .HasColumnType("float");

                    b.ToTable("Venues");
                });

            modelBuilder.Entity("WeddingBudgetCalculatorMVC.Models.ServiceProviders", b =>
                {
                    b.HasOne("WeddingBudgetCalculatorMVC.Models.Budget", null)
                        .WithMany("BudgetServiceProviders")
                        .HasForeignKey("BudgetId");
                });

            modelBuilder.Entity("WeddingBudgetCalculatorMVC.Models.BeverageProvider", b =>
                {
                    b.HasOne("WeddingBudgetCalculatorMVC.Models.ServiceProviders", null)
                        .WithOne()
                        .HasForeignKey("WeddingBudgetCalculatorMVC.Models.BeverageProvider", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WeddingBudgetCalculatorMVC.Models.Caterer", b =>
                {
                    b.HasOne("WeddingBudgetCalculatorMVC.Models.ServiceProviders", null)
                        .WithOne()
                        .HasForeignKey("WeddingBudgetCalculatorMVC.Models.Caterer", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WeddingBudgetCalculatorMVC.Models.DJ", b =>
                {
                    b.HasOne("WeddingBudgetCalculatorMVC.Models.ServiceProviders", null)
                        .WithOne()
                        .HasForeignKey("WeddingBudgetCalculatorMVC.Models.DJ", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WeddingBudgetCalculatorMVC.Models.Florist", b =>
                {
                    b.HasOne("WeddingBudgetCalculatorMVC.Models.ServiceProviders", null)
                        .WithOne()
                        .HasForeignKey("WeddingBudgetCalculatorMVC.Models.Florist", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WeddingBudgetCalculatorMVC.Models.FoodProvider", b =>
                {
                    b.HasOne("WeddingBudgetCalculatorMVC.Models.ServiceProviders", null)
                        .WithOne()
                        .HasForeignKey("WeddingBudgetCalculatorMVC.Models.FoodProvider", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WeddingBudgetCalculatorMVC.Models.Photographer", b =>
                {
                    b.HasOne("WeddingBudgetCalculatorMVC.Models.ServiceProviders", null)
                        .WithOne()
                        .HasForeignKey("WeddingBudgetCalculatorMVC.Models.Photographer", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WeddingBudgetCalculatorMVC.Models.Venue", b =>
                {
                    b.HasOne("WeddingBudgetCalculatorMVC.Models.ServiceProviders", null)
                        .WithOne()
                        .HasForeignKey("WeddingBudgetCalculatorMVC.Models.Venue", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WeddingBudgetCalculatorMVC.Models.Budget", b =>
                {
                    b.Navigation("BudgetServiceProviders");
                });
#pragma warning restore 612, 618
        }
    }
}
