

using AutoMapper;
using MediatR;
using OilProduction.Application.Contracts;

namespace OilProduction.Application.Features.WorkService.Queries.GetWorksList
{
    public class GetWorkListQueryHandler : IRequestHandler<GetWorkListQuery, List<WorksListRequest>>
    {
        private readonly IWorkRepository _workRepository;
        private readonly IMapper _mapper;

        public GetWorkListQueryHandler(IWorkRepository workRepository, IMapper mapper)
        {
            _workRepository = workRepository;
            _mapper = mapper;
        }

        public async Task<List<WorksListRequest>> Handle(GetWorkListQuery request, CancellationToken cancellationToken)
        {
            var allWorks = await _workRepository.GetAllWorksAsync(true);

            return _mapper.Map<List<WorksListRequest>> (allWorks);
        }
    }
}
