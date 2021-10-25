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
        public double ServiceChargePercent { get; set; }
    }
}
