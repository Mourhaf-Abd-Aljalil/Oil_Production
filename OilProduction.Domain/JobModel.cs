

namespace OilProduction.Domain
{
    public class JobModel
    {
        public int Id { get; set; }
        public string JobType { get; set; }
        public ICollection<WorkModel> Works { get; set; }
    }
}