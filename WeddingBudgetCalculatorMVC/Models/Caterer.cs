using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WeddingBudgetCalculatorMVC.Models
{
    [Table("Caterers")]
    public class Caterer : ServiceProviders
    {

        public string CatererStyle { get; set; }
        public double ServiceChargePercent { get; set; }
        public double RestaurantTaxPercent { get; set; }
        public double CatererCost { get; set; }

        public void CatererTotalCost (Caterer caterer)
        {
            double totalCost;
            double serviceCharge;
            double taxCharge;
            double totalTaxPercent;

            serviceCharge = caterer.CatererCost * (caterer.ServiceChargePercent / 100);
            totalTaxPercent = caterer.RestaurantTaxPercent + caterer.TaxPercent;
            taxCharge = (serviceCharge + caterer.CatererCost) * (totalTaxPercent / 100);
            totalCost = serviceCharge + taxCharge + caterer.CatererCost;
            caterer.ServiceProviderCost = totalCost;
        }


    }
}
