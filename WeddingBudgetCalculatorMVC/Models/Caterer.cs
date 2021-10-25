using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeddingBudgetCalculatorMVC.Models
{
    public class Caterer : ServiceProviders
    {
        public string CatererStyle { get; set; }
        public double ServiceChargePercent { get; set; }
        public double RestaurantTaxPercent { get; set; }


    }
}
