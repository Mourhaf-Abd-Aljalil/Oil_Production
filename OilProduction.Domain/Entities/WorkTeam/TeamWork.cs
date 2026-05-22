namespace OilProduction.Domain.Entities.WorkTeam
{
    public class TeamWork : BaseModel
    {
        public long WorkId { get; set; }
        public Worker Work { get; set; }
        public long TeamId { get; set; }
        public Team Team { get; set; }
        public bool IsManeger { get; set; }
    }
}
