using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using OilProduction.Domain.Entities.CropLand;
using OilProduction.Domain.Entities.FarmTree;
using OilProduction.Domain.Entities.Weather;
using OilProduction.Domain.Entities.WorkTeam;


namespace OilProduction.Persistence.Data
{
    public class OilProductionDbContext : DbContext
    {
        public OilProductionDbContext(DbContextOptions<OilProductionDbContext> options) 
            : base(options)
        {

        }
        public DbSet<Work> Works { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Crop> Crops { get; set; }
        public DbSet<Description> Descriptions { get; set; }
        public DbSet<Diseases> Diseases { get; set; }
        public DbSet<DiseasesCrops> DiseasesCrops { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<Nutriens> Nutriens { get; set; }
        public DbSet<Presses> Presses { get; set; }
        public DbSet<PressOrders> PressOrders { get; set; }
        public DbSet<Soil> Soils { get; set; }
        public DbSet<Farm> Farms { get; set; }
        public DbSet<Farmer> Farmers { get; set; }
        public DbSet<Fertilizers> Fertilizers { get; set; }
        public DbSet<Tree> Trees { get; set; }
        public DbSet<TreeFarmFertilizer> TreeFarmFertilizers { get; set; }
        public DbSet<TreeFarmTeam> TreeFarmTeams { get; set; }
        public DbSet<TreesFarms> TreesFarms { get; set; }
        public DbSet<WeatherConditions> WeatherConditions { get; set; }
        public DbSet<WeatherCrops> WeatherCrops { get; set; }
        public DbSet<Team>Teams { get; set; }
        public DbSet<TeamWork>TeamWorks { get; set; }
        public DbSet<TeamWorkJob> TeamWorkJobs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Description>()
    .HasOne(d => d.Nutrien1)
    .WithMany()
    .HasForeignKey(d => d.Nut1Id)
    .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Description>()
                .HasOne(d => d.Nutrien2)
                .WithMany()
                .HasForeignKey(d => d.Nut2Id)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Description>()
                .HasOne(d => d.Nutrien3)
                .WithMany()
                .HasForeignKey(d => d.Nut3Id)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Description>()
                .HasOne(d => d.Nutrien4)
                .WithMany()
                .HasForeignKey(d => d.Nut4Id)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Description>()
                .HasOne(d => d.Nutrien5)
                .WithMany()
                .HasForeignKey(d => d.Nut5Id)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<TeamWorkJob>()
    .HasOne(t => t.Job)
    .WithMany()
    .HasForeignKey(t => t.JobId)
    .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<TeamWorkJob>()
                .HasOne(t => t.Team)
                .WithMany()
                .HasForeignKey(t => t.TeamId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<TeamWorkJob>()
                .HasOne(t => t.Work)
                .WithMany()
                .HasForeignKey(t => t.WorkId)
                .OnDelete(DeleteBehavior.Restrict);



        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);
        //   optionsBuilder.UseSqlServer("Server =. ; DataBase = OilProduction; Trusted Connection = true");

        //}




    }
}
