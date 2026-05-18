using AutoMapper;
using MediatR;
using OilProduction.Application.Contracts;
using OilProduction.Domain;


namespace OilProduction.Application.Features.WorkService.Commands.CreateWork
{
    public class CreateWorkCommandHandler : IRequestHandler<CreateWorkCommand, int>
    {
        private readonly IWorkRepository _WorkRepository;
        private readonly IMapper _mapper;

        public CreateWorkCommandHandler(IWorkRepository WorkRepository, IMapper mapper)
        {
            _WorkRepository = WorkRepository;
            _mapper = mapper;
        }



        public async Task<int> Handle(CreateWorkCommand request, CancellationToken cancellationToken)
        {


            WorkModel work = _mapper.Map<WorkModel>(request);

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
