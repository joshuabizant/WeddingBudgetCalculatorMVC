using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeddingBudgetCalculatorMVC.Data;
using WeddingBudgetCalculatorMVC.Models;

namespace WeddingBudgetCalculatorMVC.Controllers
{
    public class CatererController : Controller
    {
        private readonly BudgetDbContext _db;

        public CatererController(BudgetDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Caterer> providerList = _db.Caterers;

            return View(providerList);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Caterer obj)
        {
            if (ModelState.IsValid)
            {
                _db.Caterers.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
    }
}
