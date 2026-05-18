

namespace OilProduction.Application.Features.WorkService.Queries.GetWorksList
{
    public class WorksListRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public JobDto Job { get; set; }
    }
}
