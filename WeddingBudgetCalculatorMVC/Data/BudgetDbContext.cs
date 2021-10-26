using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeddingBudgetCalculatorMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace WeddingBudgetCalculatorMVC.Data
{
    public class BudgetDbContext : DbContext
    {
        public BudgetDbContext(DbContextOptions<BudgetDbContext> options) : base(options)
        {

        }

        public DbSet<ServiceProviders> ServiceProviders { get; set; }
        public DbSet<Budget> Budgets { get; set; }
        
       public DbSet<Venue> Venues { get; set; }
        
       public DbSet<WeddingBudgetCalculatorMVC.Models.Florist> Florists { get; set; }
        
       public DbSet<WeddingBudgetCalculatorMVC.Models.DJ> DJs { get; set; }
        
       public DbSet<WeddingBudgetCalculatorMVC.Models.Caterer> Caterers { get; set; }
        
       public DbSet<WeddingBudgetCalculatorMVC.Models.Photographer> Photographers { get; set; }
        
       public DbSet<WeddingBudgetCalculatorMVC.Models.FoodProvider> FoodProviders { get; set; }
        
       public DbSet<WeddingBudgetCalculatorMVC.Models.BeverageProvider> BeverageProviders { get; set; }
        
       
       


        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Caterer>().ToTable("Caterers");
        //    modelBuilder.Entity<Venue>().ToTable("Venues");
            
        //}

    }
}
