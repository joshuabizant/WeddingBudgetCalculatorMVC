using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeddingBudgetCalculatorMVC.Data;
using WeddingBudgetCalculatorMVC.Models;

namespace WeddingBudgetCalculatorMVC.Controllers
{
    public class FloristController : Controller
    {
        private readonly BudgetDbContext _db;

        public FloristController(BudgetDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Florist> providerList = _db.Florists;

            return View(providerList);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Florist obj)
        {
            if (ModelState.IsValid)
            {
                _db.Florists.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
    }
}
