using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WeddingBudgetCalculatorMVC.Models
{
    [Table("Florists")]
    public class Florist : ServiceProviders
    {

        public int NumberOfBoquets { get; set; }
        public double CostOfBoquets { get; set; }
        public int NumberOfCorsages { get; set; }
        public double CostOfCorsages { get; set; }
        public double DecorativeFlowerCost { get; set; }
        public double FlowerAdditionalCost { get; set; }


        public void FloristTotalCost(Florist florist)
        {

            double flowerCost;
            double totalBoquetsCost;
            double totalCorsageCost;
            double taxCost;
            double totalCost;


            totalBoquetsCost = florist.CostOfBoquets * florist.NumberOfBoquets;
            totalCorsageCost = florist.CostOfCorsages * florist.NumberOfCorsages;
            flowerCost = totalCorsageCost + totalBoquetsCost + florist.DecorativeFlowerCost + florist.FlowerAdditionalCost;
            taxCost = flowerCost * (florist.TaxPercent / 100);
            totalCost = taxCost + flowerCost;
            florist.ServiceProviderCost = totalCost;
        }
    }
}
