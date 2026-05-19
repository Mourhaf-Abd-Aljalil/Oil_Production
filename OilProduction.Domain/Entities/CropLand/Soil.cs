using OilProduction.Domain.Entities.FarmTree;

namespace OilProduction.Domain.Entities.CropLand
{
    public class Soil : BaseModel
    {
        public string Type { get; set; }
        public ICollection<Farm> farms { get; set; } = [];
    }
}
