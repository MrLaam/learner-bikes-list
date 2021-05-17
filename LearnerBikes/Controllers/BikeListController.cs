using LearnerBikes.Data;
using LearnerBikes.Helpers;
using LearnerBikes.Models;
using Microsoft.AspNetCore.Http;
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

        public IActionResult Index(BikeListViewModel model, int page)
        {
            //TODO Handle null reference properly
            //model.BikeFilters.SortOrder ? ViewBag.SortOrder = model.BikeFilters.SortOrder : "[A-Z]";

            if(model.BikeFilters == null)
            {
            } else
            {
            if (HttpContext.Session.GetString("SortOrder") == null)
            {
                HttpContext.Session.SetString("SortOrder", "[A-Z]");
            } else
            {
                HttpContext.Session.SetString("SortOrder", model.BikeFilters.SortOrder);
            }

            if (HttpContext.Session.GetString("Make") == null)
            {
                HttpContext.Session.SetString("Make", "Any Make");
            }
            else
            {
                HttpContext.Session.SetString("Make", model.BikeFilters.Make);
            }

                HttpContext.Session.SetInt32("Age", model.BikeFilters.Age);

            if (HttpContext.Session.GetString("Type") == null)
            {
                HttpContext.Session.SetString("Type", "Any Type");
            }
            else
            {
                HttpContext.Session.SetString("Type", model.BikeFilters.Type);
            }
            }
            

            model.Bikes = _db.Bikes;
            model.BikePerPage = 1;
            if (page == 0) {
                model.CurrentPage = 1;
            } else {
                model.CurrentPage = page;
            }        
            BikeFilterHelper helper = new BikeFilterHelper();

                model = helper.applyFilters(model, HttpContext.Session.GetString("SortOrder"), HttpContext.Session.GetString("Make"), HttpContext.Session.GetInt32("Age"), HttpContext.Session.GetString("Type"));
        
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
