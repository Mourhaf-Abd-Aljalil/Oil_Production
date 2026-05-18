namespace OilProduction.Domain.Entities.WorkTeam
{
    public class JobModel : BaseModel
    {
        public string JobType { get; set; }
        public ICollection<WorkModel> Works { get; set; }
    }
}