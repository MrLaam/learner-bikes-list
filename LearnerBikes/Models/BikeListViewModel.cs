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
    }
}
