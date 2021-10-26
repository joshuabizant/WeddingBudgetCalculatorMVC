using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WeddingBudgetCalculatorMVC.Models
{
    [Table("Venues")]
    public class Venue : ServiceProviders
    {
        
        
        public double VenueRentalCost { get; set; }
        public double CeremonyCost { get; set; }
        public double SecurityCost { get; set; }
        public double CleaningCost { get; set; }
        public double DecorationCost { get; set; }
        public double VenueAdditionalCost { get; set; }

      
        public void CalculateTotalCost(Venue venue)
        {
            double venueCost;
            double taxCost;
            double totalCost;


            venueCost = venue.VenueRentalCost + venue.CeremonyCost + venue.SecurityCost + venue.CleaningCost + venue.DecorationCost + venue.VenueAdditionalCost;
            taxCost = venueCost * (venue.TaxPercent / 100);
            totalCost = taxCost + venueCost;
            venue.ServiceProviderCost = totalCost;
        }
    }
}
