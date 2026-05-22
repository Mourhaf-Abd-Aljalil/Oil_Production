using AutoMapper;
using OilProduction.Application.Features.WorkService.Commands.CreateWork;
using OilProduction.Application.Features.WorkService.Commands.UpdateWork;
using OilProduction.Application.Features.WorkService.Queries.GetWorkDetail;
using OilProduction.Application.Features.WorkService.Queries.GetWorksList;
using OilProduction.Domain.Entities.WorkTeam;


namespace OilProduction.Application.Mapper
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<Worker, WorkRequest>().ReverseMap();
            CreateMap<Worker, WorksListRequest>().ReverseMap();
            CreateMap<Worker, CreateWorkCommand>().ReverseMap();
            CreateMap<Worker, UpdateWorkCommand>().ReverseMap();

        }
    }
}
