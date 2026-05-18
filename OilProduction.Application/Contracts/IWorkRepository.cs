using OilProduction.Domain;


namespace OilProduction.Application.Contracts
{
    public interface IWorkRepository : IAsyncRepository<WorkModel>
    {
        Task DeleteAsync(WorkModel work);
        Task<IReadOnlyList<WorkModel>> GetAllWorksAsync(bool includeJob = false);
        Task<WorkModel> GetWorkByIdAsync(int id , bool includeJob = false);
    }
}
