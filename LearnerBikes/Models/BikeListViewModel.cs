using LearnerBikes.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnerBikes.Models
{
    public class BikeListViewModel
    {
        public IEnumerable<Bike> Bikes { get; set; }
        public BikeFiltersForm BikeFilters { get; set; }
        public int BikePerPage { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }

        public int PageCount()
        {
            return Convert.ToInt32(Math.Ceiling(Bikes.Count() / (double)BikePerPage));
        }
        public IEnumerable<Bike> PaginatedBikes()
        {
            int start = (CurrentPage - 1) * BikePerPage;
            return Bikes.OrderBy(b => b.Id).Skip(start).Take(BikePerPage);
        }

        public bool hasPreviousPage
        {
            get
            {
                return (CurrentPage > 1);
            }
        }
        public bool HasNextPage
        {
            get
            {
                return (CurrentPage < TotalPages);
            }
        }
    }
}
