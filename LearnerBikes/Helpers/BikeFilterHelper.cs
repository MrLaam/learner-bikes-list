using LearnerBikes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnerBikes.Helpers
{
    public class BikeFilterHelper
    {

        public BikeListViewModel applyFilters(BikeListViewModel viewModel, string sortOrder, string make, int? age, string type)
        {

            if (sortOrder == null && make == null && (age == 0 || age == null) && type == null)
            {
                viewModel.Bikes = viewModel.Bikes.OrderBy(s => s.Make).ThenBy(s => s.Model);
                return viewModel;
            }

            if (age.Equals(0))
            {
            }
            else
            {
                DateTime moment = DateTime.Now;
                int currentYear = moment.Year;

                if (age <= 5)
                {
                    viewModel.Bikes = viewModel.Bikes.Where(s => s.MinYear >= (currentYear - age) || s.MaxYear >= (currentYear - age));
                } else
                {
                    viewModel.Bikes = viewModel.Bikes.Where(s => s.MinYear < (currentYear - age) || s.MaxYear < (currentYear - age));
                }
                
            }

            if (type.Equals("Any Type"))
            {
            }
            else
            {
                viewModel.Bikes = viewModel.Bikes.Where(s => s.BikeType.Contains(type));
            }

            if (make.Equals("Any Make"))
            {
            }
            else if (sortOrder.Equals("(A-Z)"))
            {
                viewModel.Bikes = viewModel.Bikes.Where(s => s.Make.Contains(make)).OrderBy(s => s.Make).ThenBy(s => s.Model);
                return viewModel;
            } else if (sortOrder.Equals("(Z-A)"))
            {
                viewModel.Bikes = viewModel.Bikes.Where(s => s.Make.Contains(make)).OrderByDescending(s => s.Make).ThenBy(s => s.Model);
                return viewModel;
            }

            if (sortOrder.Equals("(A-Z)"))
            {
                viewModel.Bikes = viewModel.Bikes.OrderBy(s => s.Make).ThenBy(s => s.Model);
            } else if (sortOrder.Equals("(Z-A)"))
            {
                viewModel.Bikes = viewModel.Bikes.OrderByDescending(s => s.Make).ThenBy(s => s.Model);
            }

            return viewModel;
        }

    }
}
