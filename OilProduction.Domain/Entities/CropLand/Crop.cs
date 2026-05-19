using OilProduction.Domain.Entities.FarmTree;
using OilProduction.Domain.Entities.Weather;

namespace OilProduction.Domain.Entities.CropLand
{
    public class Crop : BaseModel
    {
        public long TreeFarmId { get; set; }
        public TreesFarms TreeFarms { get; set; }
        public DateOnly HarvestedDate { get; set; }
        public double ProductionQuantity { get; set; }

        public ICollection<WeatherCrops> WeatherCrops { get; set; } = [];
        public ICollection<DiseasesCrops> DiseasesCrops { get; set; } = [];
        public ICollection<PressOrders> PressOrders { get; set; } = [];
    }
}
