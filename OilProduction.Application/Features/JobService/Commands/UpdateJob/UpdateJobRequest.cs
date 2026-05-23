

namespace OilProduction.Application.Features.JobService.Commands.UpdateJob
{
    public class UpdateJobRequest
    {
        public long JobId { get; set; }
        public string Type { get; set; }
    }
}
