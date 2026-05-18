namespace OilProduction.Domain.Entities.CropLand
{
    public class DiseasesCrops : BaseModel
    {
        public long CropId { get; set; }
        public long DiseaseId { get; set; }
    }
}
