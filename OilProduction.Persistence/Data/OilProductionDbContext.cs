using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using OilProduction.Domain;


namespace OilProduction.Persistence.Data
{
    public class OilProductionDbContext : DbContext
    {
        public OilProductionDbContext(DbContextOptions<OilProductionDbContext> options) 
            : base(options)
        {

        }
        public DbSet<WorkModel> Works { get; set; }
        public DbSet<JobModel> Jobs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

           
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
           optionsBuilder.UseSqlServer("Server =. ; DataBase = OilProduction; Trusted Connection = true");

        }
    }
}
