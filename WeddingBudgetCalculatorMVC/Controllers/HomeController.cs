using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WeddingBudgetCalculatorMVC.Models;
using WeddingBudgetCalculatorMVC.Data;

namespace WeddingBudgetCalculatorMVC.Controllers
{
    public class HomeController : Controller
    {
      

        private readonly BudgetDbContext _db;
        public HomeController(BudgetDbContext db)
        {
            _db = db;
        }


        public IActionResult Index()
        {
            Venue testVenue = new Venue();
            testVenue.VenueRentalCost = 1000;
            testVenue.ServiceProviderName = "TestVenue";
            testVenue.TaxPercent = 7;
            testVenue.AmountPaid = 0;
            testVenue.ServiceProviderCost = (testVenue.VenueRentalCost * testVenue.TaxPercent);
            testVenue.ServiceProviderType = "Venue";

            _db.ServiceProviders.Add(testVenue);
            _db.SaveChanges();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
