using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeddingBudgetCalculatorMVC.Data;
using WeddingBudgetCalculatorMVC.Models;


namespace WeddingBudgetCalculatorMVC.Controllers
{
    public class BeverageController : Controller
    {
        private readonly BudgetDbContext _db;

        public BeverageController(BudgetDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<BeverageProvider> providerList = _db.BeverageProviders;

            return View(providerList);
        }

        public IActionResult Create()
        {
            return View();
        }

    }
}
