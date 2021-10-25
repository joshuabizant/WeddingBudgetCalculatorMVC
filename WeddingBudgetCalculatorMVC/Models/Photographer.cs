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
    }
}

