namespace OilProduction.Domain.Entities.WorkTeam
{
    public class WorkModel : BaseModel
    {
        public long JobId { get; set; }
        public JobModel Job { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }


    }
}