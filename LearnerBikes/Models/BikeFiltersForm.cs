using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnerBikes.Models
{
    public class BikeFiltersForm
    {
        public string Make { get; set; }
        public int MaxPrice { get; set; }
        public string Type { get; set; }
        public string Year { get; set; }
    }
}
