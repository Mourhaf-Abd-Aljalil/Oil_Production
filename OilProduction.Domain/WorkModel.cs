namespace OilProduction.Domain
{
    public class WorkModel
    {
        public int Id { get; set; }
        public int JobId { get; set; }
        public JobModel Job { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }


    }
}