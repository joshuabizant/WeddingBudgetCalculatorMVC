using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WeddingBudgetCalculatorMVC.Models
{
    [Table("DJs")]
    public class DJ : ServiceProviders
    {

        public int HoursOnsite { get; set; }
        public double DJCost { get; set; }

        public void DJTotalCost(DJ dj)
        {
            double taxCost;
            double totalCost;

            taxCost = dj.DJCost * (dj.TaxPercent / 100);
            totalCost = taxCost + dj.DJCost;

            dj.ServiceProviderCost = totalCost;

        }
    }
}
