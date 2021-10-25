using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WeddingBudgetCalculatorMVC.Models
{
    
    public class Budget
    {
        [Key]
        public int Id { get; set; }
        public double TotalBudget { get; set; }
        public double TotalExpenses { get; set; }
        public double RemainingBudget { get; set; }
        public string BudgetName { get; set; }
        public DateTime WeddingDate { get; set; }

        public List<ServiceProviders> BudgetServiceProviders { get; set; }
    }
}
