namespace OilProduction.Domain.Entities.WorkTeam
{
    public class Work : BaseModel
    {
        public long JobId { get; set; }
        public Job Job { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public ICollection<TeamWork> TeamWorks { get; set; } = [];
        public ICollection<TeamWorkJob> TeamWorkJobModels { get; set; } = [];

    }
}