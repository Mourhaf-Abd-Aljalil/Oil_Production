namespace OilProduction.Domain.Entities.WorkTeam
{
    public class TeamWorkJob : BaseModel
    {
        public long JobId { get; set; }
        public Job Job { get; set; }
        public long WorkId { get; set; }
        public Worker Work { get; set; }
        public long TeamId { get; set; }
        public Team Team { get; set; }
    }
}
