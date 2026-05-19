namespace OilProduction.Domain.Entities.CropLand
{
    public class DiseasesCrops : BaseModel
    {
        public long CropId { get; set; }
        public Crop Crop { get; set; }
        public long DiseaseId { get; set; }
        public Diseases Diseases { get; set; }
    }
}
