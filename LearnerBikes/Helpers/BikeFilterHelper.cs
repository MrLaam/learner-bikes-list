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

            if (viewModel.BikeFilters.Age.Equals(0))
            {
            }
            else
            {
                DateTime moment = DateTime.Now;
                int currentYear = moment.Year;

                if (viewModel.BikeFilters.Age <= 5)
                {
                    viewModel.Bikes = viewModel.Bikes.Where(s => s.MinYear >= (currentYear - viewModel.BikeFilters.Age) || s.MaxYear >= (currentYear - viewModel.BikeFilters.Age));
                } else
                {
                    viewModel.Bikes = viewModel.Bikes.Where(s => s.MinYear < (currentYear - viewModel.BikeFilters.Age) || s.MaxYear < (currentYear - viewModel.BikeFilters.Age));
                }
                
            }

            if (viewModel.BikeFilters.Type.Equals("Any Type"))
            {
            }
            else
            {
                viewModel.Bikes = viewModel.Bikes.Where(s => s.BikeType.Contains(viewModel.BikeFilters.Type));
            }

            if (viewModel.BikeFilters.SortOrder.Equals("[A-Z]"))
            {
                viewModel.Bikes = viewModel.Bikes.OrderBy(s => s.Make).ThenBy(s => s.Model);
            } else if (viewModel.BikeFilters.SortOrder.Equals("[Z-A]"))
            {
                viewModel.Bikes = viewModel.Bikes.OrderByDescending(s => s.Make).ThenBy(s => s.Model);
            }

            return viewModel;
        }

    }
}
