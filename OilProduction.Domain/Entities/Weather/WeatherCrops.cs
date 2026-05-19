using OilProduction.Domain.Entities.CropLand;

namespace OilProduction.Domain.Entities.Weather
{
    public class WeatherCrops : BaseModel
    {
        public long CropId { get; set; }
        public Crop Crop { get; set; }
        public long WeatherId { get; set; }
        public WeatherConditions Weather { get; set; }
    }
}
