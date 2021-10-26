using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeddingBudgetCalculatorMVC.Data;
using WeddingBudgetCalculatorMVC.Models;

namespace WeddingBudgetCalculatorMVC.Controllers
{
    public class ServiceProviderController : Controller
    {
        private readonly BudgetDbContext _db;

        public ServiceProviderController(BudgetDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<ServiceProviders> providerList = _db.ServiceProviders;

            return View(providerList);
        }

       

        public IActionResult CreateFlorist()
        {
            return View();
        }

        public IActionResult CreateDJ()
        {
            return View();
        }

        public IActionResult CreateCaterer()
        {
            return View();
        }

        public IActionResult CreatePhotographer()
        {
            return View();
        }

        public IActionResult CreateFoodProvider()
        {
            return View();
        }
        public IActionResult CreateBeverageProvider()
        {
            return View();
        }

    }
}
