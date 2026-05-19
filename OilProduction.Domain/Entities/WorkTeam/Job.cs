namespace OilProduction.Domain.Entities.WorkTeam
{
    public class Job : BaseModel
    {
        public string JobType { get; set; }
        public ICollection<Work> Works { get; set; } = [];
        public ICollection<TeamWorkJob> TeamWorkJobModels { get; set; } = [];
    }
}