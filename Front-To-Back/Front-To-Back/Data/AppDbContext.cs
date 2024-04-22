using Front_To_Back.Models;
using Microsoft.EntityFrameworkCore;

namespace Front_To_Back.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<HomeSlider> HomeSlider { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<ProjectImage> ProjectImages { get; set; }
    }
}
