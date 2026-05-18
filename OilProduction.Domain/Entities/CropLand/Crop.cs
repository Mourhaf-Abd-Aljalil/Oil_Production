namespace OilProduction.Domain.Entities.CropLand
{
    public class Crop : BaseModel
    {
        public long TreeFarmId { get; set; }
        public DateOnly HarvestedDate { get; set; }
        public double ProductionQuantity { get; set; }
    }
}
