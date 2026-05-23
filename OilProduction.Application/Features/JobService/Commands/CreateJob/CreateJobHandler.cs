using Microsoft.EntityFrameworkCore;
using OilProduction.Application.Contracts;
using OilProduction.Domain.Entities.WorkTeam;
using RAG.Service.Abstractions.Handlers;

namespace OilProduction.Application.Features.JobService.Commands.CreateJob
{
    public class CreateJobHandler : IRequestHandler<CreateJobRequest , Job>
    {
        private readonly IJobRepository _dbOperationService;

        public CreateJobHandler(IJobRepository dbOperationService)
        {
            _dbOperationService = dbOperationService;
        }

        public async Task<Job> HandleAsync(CreateJobRequest request, CancellationToken cancellationToken = default)
        {
            var JobExists = await _dbOperationService.Set<Job>()
                 .AnyAsync(j => j.JobType == request.JobType && j.IsValid, cancellationToken);

            if (JobExists)
            {
                throw new InvalidOperationException("JobIsExists.");
            }
            var job = new Job
            {
                JobType = request.JobType,
            };

            await _dbOperationService.AddAsync(job);
            await _dbOperationService.SaveAsync();

            return job;

        }
    }
}
