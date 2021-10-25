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

      
    }
}
