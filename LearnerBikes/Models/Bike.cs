using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LearnerBikes.Models
{
    public class Bike
    {
        [Key]
        public int Id { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public int Price { get; set; }

        public string Power { get; set; }

        public int WetWeight { get; set; }

        public string BikeType { get; set; }

        public string ImageUrl { get; set; }

        public int MinYear { get; set; }

        public int MaxYear { get; set; }
    }
}
