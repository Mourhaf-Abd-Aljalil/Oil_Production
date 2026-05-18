using MediatR;


namespace OilProduction.Application.Features.WorkService.Commands.CreateWork
{
    public class CreateWorkCommand : IRequest<int>
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
    }
}
