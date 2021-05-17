using LearnerBikes.Models;
using Microsoft.EntityFrameworkCore;

namespace LearnerBikes.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Bike> Bikes { get; set; }

    }
}
