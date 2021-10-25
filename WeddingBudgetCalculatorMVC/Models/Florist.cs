using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeddingBudgetCalculatorMVC.Models
{
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
