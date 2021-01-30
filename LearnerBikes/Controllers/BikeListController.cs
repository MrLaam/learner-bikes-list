using LearnerBikes.Data;
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

        public IActionResult Index(BikeListViewModel model, BikeFiltersForm filters, int page = 1)
        {          
            model.Bikes = _db.Bikes;
            model.BikePerPage = 30;
            model.CurrentPage = page;
            BikeFilterHelper helper = new BikeFilterHelper();

                model = helper.applyFilters(model);

                return View(model);
        }

        public IActionResult Bike(int id, BikeFiltersForm filters)
        {
            BikeListViewModel model = new BikeListViewModel();
            model.BikeFilters = filters;
            model.IndividualBike = _db.Bikes.FirstOrDefault(s => s.Id == id);
            return View(model);
        }
    }
}
