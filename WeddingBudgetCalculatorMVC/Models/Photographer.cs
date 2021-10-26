using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WeddingBudgetCalculatorMVC.Models
{
    [Table("Photographers")]
    public class Photographer : ServiceProviders
    {

        public int NumberOfPhotographers { get; set; }
        public int HoursOfPhotos { get; set; }

        public double PhotographerCost { get; set; }

        public void PhotographerTotalCost (Photographer photographer)
        {
            double totalCost;
            double taxCost;

            taxCost = photographer.PhotographerCost * (photographer.TaxPercent / 100);
            totalCost = taxCost + photographer.PhotographerCost;

            photographer.ServiceProviderCost = totalCost;
        }
    }
}

