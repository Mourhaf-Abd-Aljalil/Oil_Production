namespace OilProduction.Domain.Entities.FarmTree
{
    public class TreeFarmFertilizer : BaseModel
    {
        public long FertilizerId { get; set; }
        public long TreeFarmId { get; set; }
    }
}
