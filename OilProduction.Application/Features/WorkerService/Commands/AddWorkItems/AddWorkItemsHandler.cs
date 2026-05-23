using MediatR;
using OilProduction.Application.Contracts;
using OilProduction.Domain.Entities.WorkTeam;

namespace OilProduction.Application.Features.WorkService.Commands.AddWorkItems
{
    public class AddWorkItemsHandler : IRequestHandler<AddItemRequest, int>
    {
        private readonly IWorkRepository _workRepository;

        public AddWorkItemsHandler(IWorkRepository workRepository)
        {
            _workRepository = workRepository;
        }

        public async Task<int> Handle(AddItemRequest request, CancellationToken cancellationToken)
        {
            var ExistsWork = await _workRepository.GetWorkByIdAsync(request.WorkId);

            if (ExistsWork != null)
            {
                throw new InvalidOperationException("Work is not Exists.");
            }

            await _workRepository.BeginTransactionAsync();

            try
            {
                if (request is AddTeamWorkerRequest TeamWork)
                {
                    await AddTeamWork(TeamWork.TeamWorks, TeamWork.WorkId, cancellationToken);
                    await _workRepository.SaveAsync();
                    await _workRepository.CommitAsync();
                    return TeamWork.TeamWorks.Count;
                }
                if (request is AddTeamWorkJobRequest TeamWorkJob)
                {
                    await AddTeamWorkJob(TeamWorkJob.TeamWorkJobItems, TeamWorkJob.WorkId, cancellationToken);
                    await _workRepository.SaveAsync();
                    await _workRepository.CommitAsync();
                    return TeamWorkJob.TeamWorkJobItems.Count;
                }
                throw new InvalidOperationException("Invalid Request.");
            }
            catch (Exception ex)
            {
                await _workRepository.RollBackAsync();
                throw;
            }
                throw new InvalidOperationException("Invalid Request");
        }
        private async Task AddTeamWork(List<AddTeamWorkerDto> TeamWork , long WorkId, CancellationToken cancellationToken)
        {
            var WorkIds = TeamWork.Select(w => w.WorkId = WorkId).Distinct().ToList();

            var InvalidIds = _workRepository.Set<Worker>()
                                            .Where(w => WorkIds.Contains(w.Id))
                                            .Count();

            if(InvalidIds != WorkIds.Count)
            {
                throw new InvalidOperationException("Work is not Exists.");
            }

            var models = TeamWork.Select(tw => new TeamWork
            {
                WorkId = WorkId,
                IsManeger = tw.IsManeger,
            }).ToList();

            await _workRepository.AddRangeAsync(models);

        }
        private async Task AddTeamWorkJob(List<AddTeamWorkJobDto> TeamWorkJob , long WorkId, CancellationToken cancellationToken)
        {
            var WorkIds = TeamWorkJob.Select(w => w.WorkId = WorkId).Distinct().ToList();

            var InvalidIds = _workRepository.Set<Worker>()
                                            .Where(w => WorkIds.Contains(w.Id))
                                            .Count();

            if(InvalidIds != WorkIds.Count)
            {
                throw new InvalidOperationException("Work is not Exists.");
            }

            var models = TeamWorkJob.Select(tw => new TeamWorkJob
            {
                WorkId = WorkId,
               
            }).ToList();

            await _workRepository.AddRangeAsync(models);

        }
    }
}
