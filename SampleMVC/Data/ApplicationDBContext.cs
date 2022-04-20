using Microsoft.EntityFrameworkCore;
using SampleMVC.Models;

namespace SampleMVC.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }

    }
}
