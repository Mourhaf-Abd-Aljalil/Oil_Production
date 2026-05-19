using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace OilProduction.Persistence.Data
{
    public class OilProductionDbContextFactory : IDesignTimeDbContextFactory<OilProductionDbContext>
    {
        public OilProductionDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<OilProductionDbContext>();

            optionsBuilder.UseSqlServer("Server=.;Database=OilProduction;Trusted_Connection=True;TrustServerCertificate=True;");

            return new OilProductionDbContext(optionsBuilder.Options);
        }
    }
}
