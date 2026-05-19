using OilProduction.Domain.Entities.CropLand;

namespace OilProduction.Domain.Entities.FarmTree
{
    public class Farm : BaseModel
    {
        public long SoilId { get; set; }
        public Soil Soil { get; set; }
        public long FarmerId { get; set; }
        public Farmer Farmer { get; set; }  
        public string Location { get; set; }
        public double Area { get; set; }

        public ICollection<TreesFarms> TreesFarms { get; set; } = [];

    }
}
