
using OilProduction.Application.Features.WorkService.Queries.GetWorksList;

namespace OilProduction.Application.Features.WorkService.Queries.GetWorkDetail
{
    public class WorkRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public JobDto Job { get; set; }
    }
}
