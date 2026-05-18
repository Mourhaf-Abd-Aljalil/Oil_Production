namespace OilProduction.Domain.Entities.CropLand
{
    public class Description : BaseModel
    {
        public string DescriptionName { get; set; }
        public long Nut1Id { get; set; }
        public long Nut2Id { get; set; }
        public long Nut3Id { get; set; }
        public long Nut4Id { get; set; }
        public long Nut5Id { get; set; }
        public double Nut1Amount { get; set; }
        public double Nut2Amount { get; set; }
        public double Nut3Amount { get; set; }
        public double Nut4Amount { get; set; }
        public double Nut5Amount { get; set; }

    }
}
