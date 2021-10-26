using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WeddingBudgetCalculatorMVC.Models
{
    [Table("BeverageProviders")]
    public class BeverageProvider : ServiceProviders
    {

        public string BeverageType { get; set; }
        public double BeverageServicePercent { get; set; }
        public double BartenderCost { get; set; }
        public double RestaurantTaxPercent { get; set; }
        public double BeveragePackageCost { get; set; }

        public void BeverageTotalCost (BeverageProvider bev)
        {
            double totalCost;
            double serviceCost;
            double taxCost;
            double totalTaxPercent;

            serviceCost = bev.BeveragePackageCost * (bev.BeverageServicePercent / 100);
            totalTaxPercent = bev.RestaurantTaxPercent + bev.TaxPercent;
            taxCost = bev.BeveragePackageCost * (totalTaxPercent / 100);
            totalCost = serviceCost + taxCost + BartenderCost + BeveragePackageCost;
            
            bev.ServiceProviderCost = totalCost;
        }

    }
}
