using OilProduction.Domain.Entities.WorkTeam;


namespace OilProduction.Application.Contracts
{
    public interface IWorkRepository : IDbOperationService
    {
      
        Task<IReadOnlyList<Worker>> GetAllWorksAsync(bool includeJob = false);
        Task<Worker> GetWorkByIdAsync(int id , bool includeJob = false);
    }
}
