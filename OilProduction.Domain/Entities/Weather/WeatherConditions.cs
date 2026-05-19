namespace OilProduction.Domain.Entities.Weather
{
    public class WeatherConditions : BaseModel
    {
        public double RaindLevel { get; set; }
        public double WindLevel { get; set; }
        public DateOnly DateRecorded { get; set; }
        public ICollection<WeatherCrops> WeatherCrops { get; set; } = [];
    }
}
