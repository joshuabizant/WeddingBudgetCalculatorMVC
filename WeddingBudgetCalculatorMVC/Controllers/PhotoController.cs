using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeddingBudgetCalculatorMVC.Data;
using WeddingBudgetCalculatorMVC.Models;

namespace WeddingBudgetCalculatorMVC.Controllers
{
    public class PhotoController : Controller
    {
        private readonly BudgetDbContext _db;

        public PhotoController(BudgetDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Photographer> providerList = _db.Photographers;

            return View(providerList);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
