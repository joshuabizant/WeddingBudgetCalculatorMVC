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
        public double CostOfBoquest { get; set; }
        public int NumberOfCorsages { get; set; }
        public double CostOfCorsages { get; set; }
        public double DecorativeFlowerCost { get; set; }
        public double FlowerAdditionalCost { get; set; }
    }
}
