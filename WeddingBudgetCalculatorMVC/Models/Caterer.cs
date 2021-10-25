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


    }
}
