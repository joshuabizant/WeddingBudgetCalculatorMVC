using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeddingBudgetCalculatorMVC.Controllers
{
    public class ServiceProviderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateVenue()
        {
            return View();
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
