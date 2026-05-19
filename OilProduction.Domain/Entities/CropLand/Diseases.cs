namespace OilProduction.Domain.Entities.CropLand
{
    public class Diseases : BaseModel
    {
        public string Name { get; set; }
        public string Discription { get; set; }

        public ICollection<DiseasesCrops> DiseasesCrops { get; set; } = [];
    }
}
