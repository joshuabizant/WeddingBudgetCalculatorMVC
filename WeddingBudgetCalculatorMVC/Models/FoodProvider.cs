using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeddingBudgetCalculatorMVC.Models
{
    public class FoodProvider : ServiceProviders
    {

        public string FoodItem { get; set; }
        public double ServiceChargePercent { get; set; }
    }
}
