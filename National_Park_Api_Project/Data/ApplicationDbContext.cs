using Microsoft.EntityFrameworkCore;
using National_Park_Api_Project.Models;

namespace National_Park_Api_Project.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
                
        }
        public DbSet<NationalPark> NationalParks { get; set; }
        public DbSet<Trail> Trails {  get; set; }
        public DbSet<User> Users { get; set; }
    }
}
