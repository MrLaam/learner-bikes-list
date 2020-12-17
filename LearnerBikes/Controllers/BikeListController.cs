using LearnerBikes.Data;
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

            //IEnumerable<Bike> objList = _db.Bikes;

            if (model.BikeFilters != null)
            {
                if (model.BikeFilters.Make != null)
                {
                    if(model.BikeFilters.Make.Equals("Any Make"))
                    {
                        model.Bikes = _db.Bikes;
                        return View(model);
                    }
                    model.Bikes = model.Bikes.Where(s => s.Make.Contains(model.BikeFilters.Make));
                }

                    
            }

            return View(model);
        }
    }
}
