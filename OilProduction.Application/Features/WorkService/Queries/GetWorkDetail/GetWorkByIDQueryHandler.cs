using AutoMapper;
using MediatR;
using OilProduction.Application.Contracts;


namespace OilProduction.Application.Features.WorkService.Queries.GetWorkDetail
{
    public class GetWorkByIDQueryHandler : IRequestHandler<GetWorkByIDQuery , WorkRequest>
    {
        public IWorkRepository _workRepository;
        public IMapper _mapper;

        public GetWorkByIDQueryHandler(IWorkRepository workRepository, IMapper mapper)
        {
            _workRepository = workRepository;
            _mapper = mapper;
        }

        public async Task<WorkRequest> Handle(GetWorkByIDQuery request, CancellationToken cancellationToken)
        {
            var Work = await _workRepository.GetWorkByIdAsync(request.Id);

            return _mapper.Map<WorkRequest>(Work);
        }
    }
}
