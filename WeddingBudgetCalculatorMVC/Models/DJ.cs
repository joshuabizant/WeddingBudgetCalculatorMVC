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
    }
}
