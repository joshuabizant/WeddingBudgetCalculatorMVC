using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WeddingBudgetCalculatorMVC.Models
{
    public  abstract class ServiceProviders
    {
        [Key]
        public int Id { get; set; }
        public string ServiceProviderType { get;set; }
        public double ServiceProviderCost { get; set; }
        public string Comments { get; set; }
        public DateTime PaymentDueDate { get; set; }
        public double AmountPaid { get; set; }
        public string ServiceProviderName { get; set; }
        public string ProviderWebsite { get; set; }
        public double TaxPercent { get; set; }
    }
}
