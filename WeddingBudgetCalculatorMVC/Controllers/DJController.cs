using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeddingBudgetCalculatorMVC.Data;
using WeddingBudgetCalculatorMVC.Models;

namespace WeddingBudgetCalculatorMVC.Controllers
{
    public class DJController : Controller
    {
        private readonly BudgetDbContext _db;

        public DJController(BudgetDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<DJ> providerList = _db.DJs;

            return View(providerList);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(DJ obj)
        {
            if (ModelState.IsValid)
            {
                _db.DJs.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
    }
}
