namespace OilProduction.Domain.Entities.Weather
{
    public class WeatherCrops : BaseModel
    {
        public long CropId { get; set; }
        public long WeatherId { get; set; }
    }
}
