namespace OilProduction.Domain.Entities.WorkTeam
{
    public class TeamWork
    {
        public long WorkId { get; set; }
        public Work Work { get; set; }
        public long TeamId { get; set; }
        public Team Team { get; set; }
        public bool IsManeger { get; set; }
    }
}
