namespace OilProduction.Domain.Entities.FarmTree
{
    public class Farm : BaseModel
    {
        public long SoilId { get; set; }
        public long FarmerId { get; set; }
        public string Location { get; set; }
        public double Area { get; set; }

    }
}
