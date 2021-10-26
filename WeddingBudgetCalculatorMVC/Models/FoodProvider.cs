using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WeddingBudgetCalculatorMVC.Models
{
    [Table("FoodProviders")]
    public class FoodProvider : ServiceProviders
    {

        public string FoodItem { get; set; }
        public double FoodCost { get; set; }
        public double ServiceChargePercent { get; set; }
        public double RestaurantTaxPercent { get; set; }

        public void FoodProviderTotalCost (FoodProvider food)
        {
            double totalCost;
            double serviceChargeTotal;
            double taxTotal;
            double totalTaxPercent;

            serviceChargeTotal = food.FoodCost * (food.ServiceChargePercent / 100);
            totalTaxPercent = food.RestaurantTaxPercent + food.TaxPercent;
            taxTotal = food.FoodCost * (totalTaxPercent / 100);
            totalCost = food.FoodCost + serviceChargeTotal + taxTotal;
            food.ServiceProviderCost = totalCost;
        }
    }
}
