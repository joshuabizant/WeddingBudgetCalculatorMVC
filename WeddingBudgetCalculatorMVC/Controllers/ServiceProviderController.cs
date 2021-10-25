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
    }
}
