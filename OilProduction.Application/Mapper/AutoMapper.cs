using AutoMapper;
using OilProduction.Application.Features.WorkService.Commands.CreateWork;
using OilProduction.Application.Features.WorkService.Commands.UpdateWork;
using OilProduction.Application.Features.WorkService.Queries.GetWorkDetail;
using OilProduction.Application.Features.WorkService.Queries.GetWorksList;
using OilProduction.Domain;


namespace OilProduction.Application.Mapper
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<WorkModel, WorkRequest>().ReverseMap();
            CreateMap<WorkModel, WorksListRequest>().ReverseMap();
            CreateMap<WorkModel, CreateWorkCommand>().ReverseMap();
            CreateMap<WorkModel, UpdateWorkCommand>().ReverseMap();

        }
    }
}
