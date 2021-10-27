﻿using Microsoft.AspNetCore.Mvc;
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

            IEnumerable<Budget> providerList = _db.Budgets;

            return View(providerList);
        }

        public IActionResult Create()
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
