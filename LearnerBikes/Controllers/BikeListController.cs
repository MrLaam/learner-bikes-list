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

        public IActionResult Index(String filterName, String filterValue)
        {
            IEnumerable<Bike> objList = _db.Bikes;
            
            if (filterName != null)
            {
                if (filterName.Equals("make"))
                {
                    objList = objList.Where(s => s.Make.Contains(filterValue));
                }
            }
            return View(objList);
        }
    }
}
