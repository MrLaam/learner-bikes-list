﻿using LearnerBikes.Data;
using LearnerBikes.Helpers;
using LearnerBikes.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnerBikes.Controllers
{
    public class BikeListController : Controller
    {
        private readonly ApplicationDbContext _db;

        public BikeListController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index(BikeListViewModel model)
        {
            model.Bikes = _db.Bikes;
            BikeFilterHelper helper = new BikeFilterHelper();
            model = helper.applyFilters(model);

            return View(model);
        }
    }
}