using CleanArch.Domin.Modals;
using Microsoft.EntityFrameworkCore;

namespace CleanArch.Infra.Data.Context
{
    public class TopDevContext : DbContext
    {
        public TopDevContext(DbContextOptions<TopDevContext> options):base(options)
        {
            
        }

        public DbSet<Course> Courses { get; set; }
    }
}