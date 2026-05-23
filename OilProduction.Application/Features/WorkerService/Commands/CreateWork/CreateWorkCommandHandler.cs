using AutoMapper;
using MediatR;
using OilProduction.Application.Contracts;
using OilProduction.Domain.Entities.WorkTeam;


namespace OilProduction.Application.Features.WorkService.Commands.CreateWork
{
    public class CreateWorkCommandHandler : IRequestHandler<CreateWorkCommand, long>
    {
        private readonly IWorkRepository _WorkRepository;
        private readonly IMapper _mapper;
 
        public CreateWorkCommandHandler(IWorkRepository WorkRepository, IMapper mapper)
        {
            _WorkRepository = WorkRepository;
            _mapper = mapper;
        }

        public async Task<long> Handle(CreateWorkCommand request, CancellationToken cancellationToken)
        {


            Worker work = _mapper.Map<Worker>(request);

            CreateCommandValidator validator = new CreateCommandValidator();

            var result = await validator.ValidateAsync(request);

            if (result.Errors.Any())
            {
                throw new Exception("Work is not valid");
            }

            await _WorkRepository.AddAsync(work);

            return work.Id;

        }
    }
}
