namespace OilProduction.Domain.Entities.WorkTeam
{
    public class TeamWorkJobModel : BaseModel
    {
        public long JobId { get; set; }
        public long WorkId { get; set; }
        public long TeamId { get; set; }
    }
}
