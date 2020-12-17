using LearnerBikes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnerBikes.Helpers
{
    public class BikeFilterHelper
    {

        public BikeListViewModel applyFilters(BikeListViewModel viewModel)
        {

            if (viewModel.BikeFilters == null)
            {
                return viewModel;
            }

            if (viewModel.BikeFilters.Make.Equals("Any Make"))
            {
            } else
            {
                viewModel.Bikes = viewModel.Bikes.Where(s => s.Make.Contains(viewModel.BikeFilters.Make));
            }

            if (viewModel.BikeFilters.MaxPrice.Equals(0))
            {
            } else
            {
                viewModel.Bikes = viewModel.Bikes.Where(s => s.Price < viewModel.BikeFilters.MaxPrice);
            }

/*            if (model.BikeFilters != null)
            {
                if (model.BikeFilters.Make != null)
                {
                    if (model.BikeFilters.Make.Equals("Any Make"))
                    {
                        model.Bikes = _db.Bikes;
                        return View(model);
                    }
                    model.Bikes = model.Bikes.Where(s => s.Make.Contains(model.BikeFilters.Make));
                }


            }*/

            return viewModel;
        }

    }
}
