namespace OilProduction.Domain.Entities.FarmTree
{
    public class TreesFarms : BaseModel
    {
        public long FarmId { get; set; }
        public long TreeId { get; set; }
        public DateTime DatePlanted { get; set; }
        public double UsedPersentage { get; set; }
        public int TreeSpacing { get; set; }
    }
}
