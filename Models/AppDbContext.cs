using Microsoft.EntityFrameworkCore;
namespace EFTest.Models
{
    public class AppDbContext : DbContext 
    {
        public AppDbContext(DbContextOptions options) : base(options) {}
        public DbSet<Person> Persons {get;set;}

    }
}
