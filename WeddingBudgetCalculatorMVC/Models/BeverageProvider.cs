using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeddingBudgetCalculatorMVC.Models
{
    public class BeverageProvider : ServiceProviders
    {

        public string BeverageType { get; set; }
        public double BeverageServicePercent { get; set; }
        public double BartenderCost { get; set; }
        public double RestaurantTaxPercent { get; set; }
    }
}
