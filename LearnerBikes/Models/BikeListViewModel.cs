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
        public Bike IndividualBike { get; set; }
        public int BikePerPage { get; set; }
        public int CurrentPage { get; set; }

        public Tuple<int, int> PageCount(int pagesToDisplay, int pastMidPoint, int pagesOnEachSide, int endOfStartPage)
        {
            int pageCount = Convert.ToInt32(Math.Ceiling(Bikes.Count() / (double)BikePerPage));
            int startPage = 1;
            int endPage = 1;
            if (pageCount > 0)
            {
                if (pageCount <= pagesToDisplay)
                {
                    startPage = 1;
                    endPage = pageCount;
                } else
                {
                    if (CurrentPage >= pastMidPoint)
                {
                    startPage = CurrentPage - pagesOnEachSide;

                    if (CurrentPage <= pageCount - pagesOnEachSide)
                    {
                        endPage = CurrentPage + pagesOnEachSide;
                    } else
                    {
                        startPage = pageCount - endOfStartPage + 1;
                        endPage = pageCount;
                    }
                    
                } else
                {
                    startPage = 1;
                    endPage = endOfStartPage;
                }
                }
                
            }
            return Tuple.Create(startPage, endPage);
        }
        public IEnumerable<Bike> PaginatedBikes()
        {
            int start = (CurrentPage - 1) * BikePerPage;
            return Bikes.Skip(start).Take(BikePerPage);
        }

        public int determineTotalPages()
        {
            return Convert.ToInt32(Math.Ceiling(Bikes.Count() / (double)BikePerPage));
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
                return (CurrentPage < determineTotalPages());
            }
        }
    }
}
