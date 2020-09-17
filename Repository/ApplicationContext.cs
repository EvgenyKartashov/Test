using Microsoft.EntityFrameworkCore;
using GridWebApp.Models;

namespace GridWebApp.Repository
{
    public class ApplicationContext : DbContext
    {
        public DbSet<FederalDistrict> FederalDistricts { get; set; }
        public DbSet<City> Sities { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }
    }
}